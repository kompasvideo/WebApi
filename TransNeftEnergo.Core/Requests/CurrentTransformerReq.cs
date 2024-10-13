using TransNeftEnergo.Core.Enums;

namespace TransNeftEnergo.Core.Requests
{
    public class CurrentTransformerReq
    {
        public string Number { get; set; }
        public CurrentTransformerType Type { get; set; }
        public DateTime VerificationDate { get; set; }
        public string KTT { get; set; }
    }
}
