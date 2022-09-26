using BuberDinner.Application;
using BuberDinner.Infrastructure;
var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.
    AddApplication()
    .AddInfrastructure(builder.Configuration);
    builder.Services.AddControllers();
}

// Add services to the container.


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

var app = builder.Build();
{
    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}

