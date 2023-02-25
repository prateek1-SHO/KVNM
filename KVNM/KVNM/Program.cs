using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//Add Logger
Log.Logger = new LoggerConfiguration().MinimumLevel.Debug().WriteTo.File("Log/Villatext.txt", rollingInterval: RollingInterval.Day).CreateLogger();
  builder.Host.UseSerilog();
builder.Services.AddControllers();
//if you want to return only xmal data formate the you can do that 
builder.Services.AddControllers(option=> {
    option.ReturnHttpNotAcceptable = true; 
}).AddNewtonsoftJson();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
