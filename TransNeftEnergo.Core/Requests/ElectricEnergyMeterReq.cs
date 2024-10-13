using TransNeftEnergo.Core.Enums;

namespace TransNeftEnergo.Core.Requests
{
    public class ElectricEnergyMeterReq
    {
        public string Name { get; set; }
        public MeterType Type { get; set; }
        public DateTime VerificationDate { get; set; }
    }
}
