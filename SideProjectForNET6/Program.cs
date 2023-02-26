using SideProjectForNET6.Repository;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddScoped<IProductRepository, ProductRepository>();




var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
