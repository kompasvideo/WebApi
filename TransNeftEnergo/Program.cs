using System.Text.Json.Serialization;
using System.Text.Json;
using System;
using TransNeftEnergo.Data;
using TransNeftEnergo.Logic;
using SeedData = TransNeftEnergo.WebAPI.SeedData;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSwaggerGen(c =>
{
    c.ResolveConflictingActions(apiDescriptions => apiDescriptions.FirstOrDefault());
});
builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
        options.JsonSerializerOptions.WriteIndented = true;
        options.JsonSerializerOptions.Converters.Add( new JsonStringEnumConverter(JsonNamingPolicy.CamelCase));

    }); 
builder.Services.AddSwaggerGen();
builder.Services.AddData(builder.Configuration);
builder.Services.AddLogic();
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();
SeedData.EnsurePopulated(app);
app.MapControllers();
await app.RunAsync();