using System.Runtime.CompilerServices;

namespace MiddleWare02.CustomMiddleWare
{
    public static class CustomMiddleWareExecention
    {
        // Created Exection Method Of IApplicationBuilder Type
        public static IApplicationBuilder UseCustomMiddleWare(this IApplicationBuilder app
        )
        {
            return app.UseMiddleware<CustomMiddlWare>();
        }
    }
}
