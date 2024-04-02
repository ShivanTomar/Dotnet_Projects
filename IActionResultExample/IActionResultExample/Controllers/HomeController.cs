using Microsoft.AspNetCore.Mvc;
using IActionResultExample.Model;

namespace IActionResultExample.Controllers
{
    public class HomeController : Controller
    {
        //URI: /bookstore?bookid=10&isloggedin=true
        [Route("bookstore/{bookid?}/{isloggedin?}")]
        public IActionResult Index([FromQuery]int? bookid,[FromRoute]bool? isloggedin, Book book)
        {
            //Book id should be applied
            if (bookid.HasValue==false)
            {
                //Response.StatusCode = 400;
                return BadRequest("Book id is not supplied");
            }

            //Book id can't be empty
            if (bookid<=0)
            {
                //Response.StatusCode = 400;
                return BadRequest("Book id can't be null or empty");
            }

            //Book id should be between 1 to 1000
            //int bookId =Convert.ToInt16( ControllerContext.HttpContext.Request.Query["bookid"]);
            if (bookid <= 0) {
                //Response.StatusCode = 400;
                return BadRequest("Book id cant be less then or equal to zero");
            }
            if (bookid >1000)
            {
                //Response.StatusCode = 400;
                return NotFound("Book id cant be grater then or equal to 1000");
            }
            //is logged in should be true
            if (isloggedin == false)
            {
                //Response.StatusCode = 401;
                return StatusCode(401);

            }


            return Content($"BOOK ID: {bookid},Book:{book}","text/plain");
            //return File("/sample.pdf","application/pdf");
        }
    }
}
