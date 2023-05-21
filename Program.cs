using CleanWebAPI.Exceptions;
using CleanWebAPI.Models.Context;
using CleanWebAPI.Repositories.Implementation;
using CleanWebAPI.Repositories.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//var connectionString = builder.Configuration.GetConnectionString("MySuperConnection") ?? throw new InvalidOperationException("Connection string was not found");
var connectionString = builder.Configuration.GetConnectionString("PostgreSQLConnectionString") ?? throw new InvalidOperationException("Connection string was not found");

builder.Services.AddDbContext<MyPetContext>(options => options
                .UseNpgsql(connectionString));

builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddMediatR(cfg => cfg
                .RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
builder.Services.AddMemoryCache();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(setupAction =>
{
    setupAction.AddPolicy("default",
        builder =>
        {
            builder.WithOrigins("*").AllowAnyHeader().AllowAnyMethod();
        });
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseExceptionHandler(builder =>
    {
        builder.Run(async context =>
        {
            var logger = context.RequestServices.GetService<ILogger<Program>>();
            var error = context.Features.Get<IExceptionHandlerFeature>();

            context.Response.StatusCode = (int)ValidErrorCode.GetErrorCode(error.Error);
            context.Response.ContentType = "application/json";
            var errorMessage = "Error occured";
            if (error != null && error.Error is Exception)
            {
                errorMessage = error.Error.Message;
            }

            var response = new
            {
                errorCode = context.Response.StatusCode,
                error = errorMessage
            };

            var json = JsonConvert.SerializeObject(response);
            await context.Response.WriteAsync(json);
            logger!.LogError(response.error, json);
        });
    });
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
