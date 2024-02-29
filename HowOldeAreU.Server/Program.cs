using HowOldeAreU.Server.Interfaces;
using HowOldeAreU.Server.Mapping;
using HowOldeAreU.Server.Services;

var builder = WebApplication.CreateBuilder(args);

//SwaggerGEn documentation
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Add services to the container.
builder.Services.AddControllers();

builder.Services.AddSingleton<IfaceServices, IfaceServices>();
builder.Services.AddSingleton<Ifaces, Ifaces>();
builder.Services.AddScoped<IfaceServices, FaceService>();

builder.Services.AddAutoMapper(typeof(FaceMapping));

var app = builder.Build();

//configure swager
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseDefaultFiles();
app.UseStaticFiles();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapFallbackToFile("/index.html");

app.Run();
