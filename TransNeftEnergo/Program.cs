using TransNeftEnergo.Data;
using TransNeftEnergo.Logic;
using SeedData = TransNeftEnergo.WebAPI.SeedData;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSwaggerGen(c =>
{
    c.ResolveConflictingActions(apiDescriptions => apiDescriptions.FirstOrDefault());
});
builder.Services.AddControllers();
builder.Services.AddSwaggerGen();
builder.Services.AddData(builder.Configuration);
builder.Services.AddLogic();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
WebApplication web;
SeedData.EnsurePopulated(app);
app.MapControllers();

app.Run();

//Microsoft.Data.SqlClient.SqlException: "Introducing FOREIGN KEY constraint
//'FK_AccountingPeriod_ElectricityMeasurementPoints_ElectricityMeasurementPointId'
//on table 'AccountingPeriod' may cause cycles or multiple cascade paths.
//Specify ON DELETE NO ACTION or ON UPDATE NO ACTION, or modify other
//FOREIGN KEY constraints.
//Could not create constraint or index. See previous errors."
