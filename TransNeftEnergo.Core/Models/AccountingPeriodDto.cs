namespace TransNeftEnergo.Core.Entity
{
    public class AccountingPeriodDto
    {
        public int CalculationDeviceId { get; set; }
        public CalculationDeviceDto? CalculationDevice { get; set; }
        public int ElectricityMeasurementPointId { get; set; }
        public ElectricityMeasurementPointDto? ElectricityMeasurementPoint { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
