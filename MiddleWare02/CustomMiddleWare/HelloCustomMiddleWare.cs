using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace MiddleWare02.CustomMiddleWare
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class HelloCustomMiddleWare
    {
        private readonly RequestDelegate _next;

        public HelloCustomMiddleWare(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext)
        {
            // before logic
            return _next(httpContext);
            // after logic
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class HelloCustomMiddleWareExtensions
    {
        public static IApplicationBuilder UseHelloCustomMiddleWare(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<HelloCustomMiddleWare>();
        }
    }
}
