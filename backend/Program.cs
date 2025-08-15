using System;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!"); // Using anonomous functions
app.MapGet("/hell", Hell);

app.Run();

string Hell()
{
    System.IO.File.ReadAllText("file.txt");
    var message = "Hell";
    return message + "!";
}
