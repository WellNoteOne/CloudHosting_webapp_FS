var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!"); // Using anonomous functions
app.MapGet("/hell", Hell);

app.Run();

string Hell()
{
    //First way
    var helloFolder = new DirectoryInfo(Directory.GetCurrentDirectory());
    var filePath = Path.Combine(helloFolder.FullName, "file.txt");

    //Short way
    var helloPath = Path.Combine(Directory.GetCurrentDirectory(), "file.txt");

    // print to console path of the file
    Console.WriteLine($"Reading 1st hello from: {filePath}");
    Console.WriteLine($"Reading 2nd hello from: {helloPath}");

    var message = File.ReadAllText(helloPath);
    return message + "!";
}
