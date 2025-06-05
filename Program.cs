using Serilog;

Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Debug()
    .Enrich.FromLogContext()  // ✅ important!
    .WriteTo.Seq("http://localhost:5341")
    .WriteTo.Console()
    .CreateLogger();

var builder = WebApplication.CreateBuilder(args);
builder.Host.UseSerilog(); // 👈 Important

builder.Services.AddControllers();
var app = builder.Build();

app.MapControllers();
app.Run();
