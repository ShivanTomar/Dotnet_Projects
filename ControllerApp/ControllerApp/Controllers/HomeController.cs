using Microsoft.AspNetCore.Mvc;

namespace ControllerApp.Controller
{
    [Controller]
    class HomeController 
    {
        [Route("/abc")]
        public string method1() {
            return "hello";
        }
    }
}
