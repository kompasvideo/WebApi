namespace TransNeftEnergo.Core.Entity
{
    public class AccountingPeriodDto
    {
        public int CalculationDeviceKey { get; set; }
        public CalculationDeviceDto CalculationDevice { get; set; }
        public int ElectricityMeasurementPointKey { get; set; }
        public ElectricityMeasurementPointDto ElectricityMeasurementPoint { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
