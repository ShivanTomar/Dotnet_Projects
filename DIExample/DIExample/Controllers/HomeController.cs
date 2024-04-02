using Microsoft.AspNetCore.Mvc;
using ServiceContracts;
using Services;

namespace DIExample.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICitiesService _citiesService;
        private readonly IServiceScopeFactory _serviceScopeFactory;
        //Constructor
         public HomeController(ICitiesService citiesService, IServiceScopeFactory serviceScopeFactory) { 
             _citiesService = citiesService;
            _serviceScopeFactory = serviceScopeFactory;



         }
         
        [Route("/")]
        public IActionResult Index()
        {
            List<string> cities= _citiesService.GetCities();

            using (IServiceScope scope = _serviceScopeFactory.CreateScope()) {

                //Inject CitieService
                ICitiesService citiesService=  scope.ServiceProvider.GetService<ICitiesService>();
                //DB works
                //ViewBag.InstanceId_CitiesServicece_InScope = citiesService.;


            } //end of schope; it calls citiesService.Dispose()

                return View(cities);
        }
    }
}
