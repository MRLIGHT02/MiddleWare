

namespace MiddleWare02.CustomMiddleWare
{
    public class CustomMiddleWareClass : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync("Custom MiddleWare Started");
            await context.Response.WriteAsync("Second Middleware Example of CustomerMiddleWare");
            await next(context);
            await context.Response.WriteAsync("Custom MiddleWare Ended");

        }
    }
}
