using PrimeDecomp.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddGrpc();

var app = builder.Build();
app.MapGrpcService<PrimeCalculatorServiceImpl>();  // Updated class name
app.MapGet("/", () => "Prime Decomposition Service");
app.Run();
