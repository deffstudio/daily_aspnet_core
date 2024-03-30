using Microsoft.AspNetCore.HttpLogging;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpLogging(opts => opts.LoggingFields = HttpLoggingFields.RequestProperties);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseHttpLogging();
}

app.MapGet("/", () => "Welcome to ASP.NET Core Verandah!");
app.MapGet("/student", () => new Student("Gabriel", "Jesus"));

app.Run();

public record Student(string FirstName, string LastName);
