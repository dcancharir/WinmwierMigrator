using Microsoft.EntityFrameworkCore;
using WinmeierDataWarehouseClient.Context;
using Serilog;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<wgdb_000_winmeierContext>(options =>
{
	options.UseSqlServer(builder.Configuration.GetConnectionString("WinmeierConnection"));
});
//logs
builder.Host.ConfigureLogging(logging =>
{
	var logFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logs");
	if(!Directory.Exists(logFolder))
	{
		Directory.CreateDirectory(logFolder);
	}

	var logFile = Path.Combine(logFolder, "winmeier-.log");
	logging.AddSerilog();
	Log.Logger = new LoggerConfiguration()
		.MinimumLevel.Information()
		.MinimumLevel.Override("Microsoft", Serilog.Events.LogEventLevel.Error)
		.MinimumLevel.Override("Microsoft.AspNetCore", Serilog.Events.LogEventLevel.Error)
		.MinimumLevel.Override("Microsoft.EntityFrameworkCore", Serilog.Events.LogEventLevel.Error)
		.WriteTo.File(logFile, rollingInterval: RollingInterval.Day)
		.CreateLogger();
});
var logFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logs");
var logFile = Path.Combine(logFolder, "winmeier-.log");
Log.Logger = new LoggerConfiguration()
	  .MinimumLevel.Information() // Nivel mínimo de log para todos los mensajes
	  .MinimumLevel.Override("Microsoft", Serilog.Events.LogEventLevel.Error) // Nivel mínimo de log para mensajes de Microsoft
	  .MinimumLevel.Override("Microsoft.AspNetCore", Serilog.Events.LogEventLevel.Error) // Nivel mínimo de log para mensajes de ASP.NET Core
	  .MinimumLevel.Override("Microsoft.EntityFrameworkCore", Serilog.Events.LogEventLevel.Error) // Nivel mínimo de log para mensajes de EF Core
	  .WriteTo.File(logFile, rollingInterval: RollingInterval.Day)
	  .CreateLogger();
var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI(c => {
	c.ConfigObject.AdditionalItems.Add("syntaxHighlight", false);
	c.DocExpansion(Swashbuckle.AspNetCore.SwaggerUI.DocExpansion.None);
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
