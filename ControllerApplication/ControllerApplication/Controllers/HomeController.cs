using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;
using System.Reflection.Metadata.Ecma335;
using ControllerApplication.Models;

namespace ControllerApplication.Controllers
{
    [Controller]
    public class HomeController : Microsoft.AspNetCore.Mvc.Controller   
    {
        [Route("method")]
        public string method()
        {
            return "hello method";
        }

        [Route("content")]
        public ContentResult Index()
        {
            return new ContentResult()
            {
                Content = "HELLO THIS IS CONTENT FROM INEDX MRTHOD",
                ContentType = "text/plain"
            };

            // return Content("HELLO THIS IS CONTENT FROM INEDX MRTHOD", "text/plain"  );
        }

        [Route("person")]
        public JsonResult persons() {
            Person person = new Person()
            {
                Id = Guid.NewGuid(),
                FirstName = "Shivani",
                LastName = "Tomar",
                Age = 25
            };
            //return "{\"key\": \"value\"}";
            //return new JsonResult(person);
            return Json(person);
        }
    }
}
