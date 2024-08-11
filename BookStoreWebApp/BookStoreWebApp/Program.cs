using BookStoreWebApp;
using BookStoreWebApp.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using MySqlConnector;

/* builder is a module:
 * - used to control dependency injection
 * - deal with serveices and various things you can add to your program
 * */
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

/* 
  - builder.Services accesses the service collection that holds the definitions of services that will be available for dependency injection
    throughout the application

  - (_ => new MySqlConnection(...)):

    + This is a lambda expression that specifies how to create the MySqlConnection instance.
    + `_` is a placeholder for a parameter (not used in this case) typically representing a service provider or any other required dependency.
    + new MySqlConnection(...) is the code that creates a new instance of MySqlConnection.

 */
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"), new MySqlServerVersion(new Version(8, 0, 34)));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
// Control your pipeline
// Control your middlewears
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();

}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

// where the app runs
app.Run();
