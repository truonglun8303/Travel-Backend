using do_an_Travel_Backend.Data;
using do_an_Travel_Backend.Models;
using do_an_Travel_Backend.Service.Travels;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<TravelDbContext>(
        option =>
        {
            option.UseSqlServer(builder.Configuration.GetConnectionString("TravelDatabase"));
        }
);
builder.Services.AddTransient<ITravelsService, TravelsService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
//Show UseCors with CorsPlicyBuilder
app.UseCors(builder =>
{
    builder.AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader();
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
