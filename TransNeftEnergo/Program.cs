using TransNeftEnergo.Data;
using TransNeftEnergo.Logic;
using SeedData = TransNeftEnergo.WebAPI.SeedData;

DateIn dateIn1 = new DateIn {
    Date = new DateTime(2018,2,1)
};
DateIn dateIn2 = new()
{
    Date = new DateTime(2018, 2, 1)
};
DateIn dateIn3 = new()
{
    Date = new DateTime(2018, 3, 1)
};
DateIn dateIn4 = new()
{
    Date = new DateTime(2017, 2, 1)
};
Rasch rasch1 = new()
{
    Name ="one",
    DateIns = [dateIn1, dateIn2]
};
Rasch rasch2 = new()
{
    Name = "two",
    DateIns = [dateIn3, dateIn4]
};
List<Rasch> rasches = [rasch1, rasch2];
//HashSet<Rasch> rasches2 = new();
//foreach(Rasch rasch in rasches)
//{
//    foreach(var item in rasch.DateIns)
//    {
//        if (item.Date.Year == 2018)
//            rasches2.Add(rasch);
//    }
//}
var rasches2 = rasches.Where(rasch => 
    rasch.DateIns.Any(item => item.Date.Year == 2018)).ToList();
Console.WriteLine(rasches2.Count);


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


class DateIn
{
    public DateTime Date { get; set; }
}
class Rasch
{
    public string Name { get; set; }
    public List<DateIn> DateIns { get; set; }
}