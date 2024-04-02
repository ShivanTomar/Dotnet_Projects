namespace MyApp
{
    public class CustomMiddleware: IMiddleware
    {
       
        public async Task InvokeAsync(HttpContext context, RequestDelegate next) {
            
            var _next = next;
        }
    }
}
