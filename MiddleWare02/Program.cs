using MiddleWare02.CustomMiddleWare;

var builder = WebApplication.CreateBuilder(args);
// Registering The MiddleWare Service
builder.Services.AddTransient<CustomMiddleWareClass>();
var app = builder.Build();

/// MidleWare-1 
app.Use(async (HttpContext context, RequestDelegate next) =>
{
    await context.Response.WriteAsync("hello");
    await next(context);
});
/// CustomMiddleware use 
 //app.UseMiddleware<CustomMiddleWareClass>();
// Using CustomExtions Method To call MiddleWare
app.UseCustomMiddleWare();

/// MidleWare-3
app.Run(async (HttpContext context) =>
{
    await context.Response.WriteAsync("hello again third time");
});


app.Run();
