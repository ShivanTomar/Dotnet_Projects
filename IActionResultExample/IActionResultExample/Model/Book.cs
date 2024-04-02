using Microsoft.AspNetCore.Mvc;

namespace IActionResultExample.Model
{
    public class Book
    {
        [FromQuery]
        public int? BookId { get; set; }

        public string? Author { get; set; }

        public override string ToString()
        {
            return $"Bookk Object - Book id:{BookId}, Author:{Author}";
        }
    }
}
