var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();



app.Run();


//app.Run(async (context) => await context.Response.WriteAsync("Welcome at suicide world"));


/*app.Run(async (context) =>
{
    context.Response.StatusCode = 404;
    var response = context.Response;
    response.Headers.ContentLanguage = "en-En";
    response.Headers.ContentType = "text/plain; character=utf-8";
    response.Headers.Append("secret-id", "256");
    await context.Response.WriteAsync("Welcome at this suicide world");
});*/

/*app.Run(async (context) =>
{
    var response = context.Response;
    response.Headers.ContentType = "text/html; character=utf-8";
    await response.WriteAsync("<h2>Welcome</h2> at this suicide world");
});*/