Console.WriteLine(@$"Current Directory:
     {Directory.GetCurrentDirectory()}");

Console.WriteLine(@$"Executing Assembly: 
    {Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)}");



var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

string path = Directory.GetCurrentDirectory();
Console.WriteLine("Program strarts with this directory {0}" + path);

string Hell()
{
    //First way
    var helloFolder = new DirectoryInfo(Directory.GetCurrentDirectory());
    Console.WriteLine("Step 1");
    var filePath = Path.Combine(helloFolder.FullName, "file.txt");

    //Short way
    var helloPath = Path.Combine(Directory.GetCurrentDirectory(), "file.txt");

    // print to console absolute path of the file
    Console.WriteLine($"Reading 1st hello from: {filePath}");
    Console.WriteLine($"Reading path from short way: {helloPath}");

    var message = File.ReadAllText(filePath);
    return "Read from File ()" + message;
}


app.MapGet("/", () => "Hello World!"); // Using anonomous functions
app.MapGet("/hell", Hell);

app.Run();



// deploying with az webapp up --name mega-best -g test1 --location westeurope --sku B1 --os-type Linux