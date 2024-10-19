using TransNeftEnergo.Core.Enums;

namespace TransNeftEnergo.Core.Responses
{
    public class ElectricEnergyMeterResp
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public MeterType? Type { get; set; }
        public DateTime? VerificationDate { get; set; }
    }
}
