using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace ConfugrationExamples.Controllers
{
    public class HomeController : Controller
    {
        //private field
        private readonly WeatherApiOptions _options;
        //constructor
        public HomeController(IOptions<WeatherApiOptions> weatherApiOptions)
        {
            _options= weatherApiOptions.Value;
        }
        [Route("/")]
        public IActionResult Index()
        {
            //ViewBag.MyKey = _configuration["weatherapi:ClientId"];
            //ViewBag.MyApikey = _configuration.GetValue<string>("weatherapi:ClientSecret", "HEYY THIS IS DEFAULT VALUE");

           // WeatherApiOptions options = _configuration.GetSection("weatherapi").Get<WeatherApiOptions>();

            ViewBag.MyKey = _options.ClientId;
            ViewBag.MyApikey = _options.ClientSecret;


            return View();
        }
    }
}
