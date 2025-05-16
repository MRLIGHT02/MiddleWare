

namespace MiddleWare02.CustomMiddleWare
{
    public class CustomMiddleWareClass : IMiddleware
    {
        public Task InvokeAsync(HttpContext context, RequestDelegate next)
        {

        }
    }
}
