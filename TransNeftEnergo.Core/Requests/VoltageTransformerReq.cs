using TransNeftEnergo.Core.Enums;

namespace TransNeftEnergo.Core.Requests
{
    public class VoltageTransformerReq
    {
        public string Number { get; set; }
        public VoltageTransformerType Type { get; set; }
        public DateTime VerificationDate { get; set; }
        public string KTN { get; set; }
    }
}
