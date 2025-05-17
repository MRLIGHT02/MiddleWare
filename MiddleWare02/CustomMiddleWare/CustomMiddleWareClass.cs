


namespace MiddleWare02.CustomMiddleWare
{
    public class CustomMiddlWare : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync("Middle Ware Piple Is Started");

            await next(context);
        }
    }
}
