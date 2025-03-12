using EmployeeManagment;

var builder = WebApplication.CreateBuilder(args);

var root = Directory.GetCurrentDirectory();
var dotenv = Path.Combine(root, ".env");
DotEnv.Load(dotenv);

builder.Configuration.AddEnvironmentVariables();

//builder.Services.AddDbContext<MyDbContext>(options =>
//    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();