using VirtualPark.BusinessLogic.ClocksApp.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();

builder.Services.AddScoped<IClockAppService, ClockAppService>();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
