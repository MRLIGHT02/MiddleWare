var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Run(async (HttpContext context) =>
{
    await context.Response.WriteAsync("hello");
});
app.Run(async (HttpContext context) =>
{
    await context.Response.WriteAsync("hello again");
});

app.Run();
