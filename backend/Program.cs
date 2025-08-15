using System;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!"); // Using anonomous functions
app.MapGet("/hell", Hell);

app.Run();

string Hell()
{

    var message = System.IO.File.ReadAllText("./file.txt");
    return message + "!";
}
