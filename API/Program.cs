using Microsoft.EntityFrameworkCore;
using Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<AppDbContext>(opt => // defined as a services in the Program.cs file, and then injected into the ActivitiesController constructor. This allows the controller to interact with the database through the AppDbContext instance.
{
    opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
});
//// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
//builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    //app.MapOpenApi();
//}

//app.UseHttpsRedirection();

//app.UseAuthorization();

app.MapControllers();

using var scope = app.Services.CreateScope(); // This creates a new scope for the services, which is necessary for resolving scoped services like the AppDbContext.
var services = scope.ServiceProvider; // This retrieves the service provider from the created scope, allowing you to resolve services within that scope.

try
{
    var context = services.GetRequiredService<AppDbContext>(); // This resolves the AppDbContext service from the service provider, allowing you to interact with the database context.
    await context.Database.MigrateAsync(); // This applies any pending migrations to the database, ensuring that the database schema is up to date with the application's data model.
    await DbInitializer.SeedData(context); // This calls the SeedData method of the DbInitializer class, which populates the database with initial data if it is empty. This is useful for setting up default data for testing or development purposes.
}
catch (Exception ex)
{
    var logger = services.GetRequiredService<ILogger<Program>>(); // If an exception occurs during the seeding process, this resolves a logger service for the Program class to log the error.
    logger.LogError(ex, "An error occurred during migration."); // This logs the error message along with the exception details.
}
    app.Run();
