namespace TransNeftEnergo.Data.Entity
{
    public class AccountingPeriod
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int CalculationDeviceId { get; set; }
        public CalculationDevice? CalculationDevice { get; set; }
        public int ElectricityMeasurementPointId { get; set; }
        public ElectricityMeasurementPoint? ElectricityMeasurementPoint { get; set; }
    }
}
