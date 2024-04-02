using Microsoft.AspNetCore.Mvc;
using ModelVelidationExample.CustomModelBinders;
using ModelVelidationExample.Models;

namespace ModelVelidationExample.Controllers
{
    public class HomeController : Controller
    {
        //  [Bind(nameof(Person.PersonName), nameof(Person.Email), nameof(Person.Password), nameof(Person.ConfirmPassword))]
        // [FromBody] [ModelBinder(BinderType = typeof(PersonModelBinder))]
        [Route("register")]
        public IActionResult Index(Person person)
        {
            if (!ModelState.IsValid) { 
             List<string> errors = new List<string>();
                foreach(var value in ModelState.Values)
                {
                    foreach(var error in value.Errors)
                    {
                        errors.Add(error.ErrorMessage);
                    }
                }
                string err=string.Join("\n",errors);
                return BadRequest(err);
            }

            return Content($"Person:{person}");
        }
    }
}
