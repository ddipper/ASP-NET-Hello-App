



































/*var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Run(async (context) =>
{

    context.Response.ContentType = "text/html; charset=utf-8";

    if(context.Request.Path == "/postuser")
    {
        var form = context.Request.Form;
        string name = form["name"];
        string age = form["age"];
        string[] langs = form["langs"];
        string langList = "";

        foreach(var l in langs)
        {
            langList += $" {l}";
        }

        await context.Response.WriteAsync($"<div><p>Name: {name}</p>" + 
            $"<p>Age: {age}</p>" + 
            $"<div>Languages: {langList}</div></div>");
    }
    else
    {
        await context.Response.SendFileAsync("html/index.html");
    }
});

app.Run();*/


/*app.Run(async (context) =>
{
    context.Response.ContentType = "text/html; charset=utf-8";

    if (context.Request.Path == "/postuser")
    {
        var form = context.Request.Form;
        string name = form["name"];
        string age = form["age"];
        await context.Response.WriteAsync($"<div><p>Name: {name}</p><p>Age: {age}</p></div>");
    }
    else
    {
        await context.Response.SendFileAsync("html/index.html");
    }
});*/


/*app.Run(async (context) =>
{
    var fileProvider = new PhysicalFileProvider(Directory.GetCurrentDirectory());
    var fileInfo = fileProvider.GetFileInfo("Night.png");

    context.Response.Headers.ContentDisposition = "attachment; filename=ddipperNight.png";
    await context.Response.SendFileAsync(fileInfo);
});*/


/*app.Run(async (context) =>
{
    var path = context.Request.Path;
    var fullPath = $"html/{path}";
    var response = context.Response;

    response.ContentType = "text/html; charser=utf-8";
    if(File.Exists(fullPath))
    {
        await response.SendFileAsync(fullPath);
    }
    else
    {
        response.StatusCode = 404;
        await response.WriteAsync("<h2>Not Found</h2>");
    }

    context.Response.ContentType = "text/html";
    await context.Response.SendFileAsync("html/index.html");
});*/


//app.Run(async (context) => await context.Response.SendFileAsync("Night.png"));


/*app.Run(async (context) =>
{
    context.Response.ContentType = "text/html";
    var stringBuilder = new System.Text.StringBuilder("<h3>QueryString parametrs</h3><table>");
    stringBuilder.Append("<tr><td>Parametr</td><td>Value</td></tr>");

    foreach(var param in context.Request.Query)
    {
        stringBuilder.Append($"<tr><td>{param.Key}</td><td>{param.Value}</td></tr>");
    }

    stringBuilder.Append("</table>");

    string name = context.Request.Query["name"];
    string age = context.Request.Query["age"];

    await context.Response.WriteAsync(stringBuilder.ToString() + $"\n {name}: {age}");
});*/


//app.Run(async (context) => await context.Response.WriteAsync("Welcome at suicide world"));


/*var path = context.Request.Path;
var now = DateTime.Now;
var response = context.Response;

if (path == "/date")
    await response.WriteAsync($"Date: {now.ToShortDateString()}");
if (path == "/time")
    await response.WriteAsync($"Time: {now.ToShortTimeString()}");*/


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