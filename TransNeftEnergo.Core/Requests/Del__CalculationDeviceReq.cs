using TransNeftEnergo.Core.Entity;

namespace TransNeftEnergo.Core.Requests
{
    // расчётный прибор учёта
    public class Del__CalculationDeviceReq
    {
        public string? Name { get; set; }
        //public List<ElectricityMeasurementPointDto?>? ElectricityMeasurementPoints { get; set; } = new();
        //public List<AccountingPeriodDto?>? AccountingPeriods { get; set; } = new();
    }
}
