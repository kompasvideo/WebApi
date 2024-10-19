using TransNeftEnergo.Data;
using TransNeftEnergo.Logic;
using SeedData = TransNeftEnergo.WebAPI.SeedData;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSwaggerGen(c =>
{
    c.ResolveConflictingActions(apiDescriptions => apiDescriptions.FirstOrDefault());
});
builder.Services.AddControllers();
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