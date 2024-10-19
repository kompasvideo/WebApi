using TransNeftEnergo.Core.Enums;

namespace TransNeftEnergo.Core.Responses
{
    public class VoltageTransformerResp
    {
        public int? Id { get; set; }
        public string? Number { get; set; }
        public VoltageTransformerType? Type { get; set; }
        public DateTime? VerificationDate { get; set; }
        public string? KTN { get; set; }
    }
}
