var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

/// MidleWare-1 
app.Use(async (HttpContext context, RequestDelegate next) =>
{
    await context.Response.WriteAsync("hello");
    await next(context);
});
/// MidleWare-2
app.Use(async (HttpContext context, RequestDelegate next) =>
{
    await context.Response.WriteAsync("hello again");
    await next(context);
});
/// MidleWare-3
app.Run(async (HttpContext context) =>
{
    await context.Response.WriteAsync("hello again third time");
});


app.Run();
