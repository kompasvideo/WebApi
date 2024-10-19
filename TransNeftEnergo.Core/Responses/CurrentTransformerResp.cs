using TransNeftEnergo.Core.Enums;

namespace TransNeftEnergo.Core.Responses
{
    public class CurrentTransformerResp
    {
        public int? Id { get; set; }
        public string? Number { get; set; }
        public CurrentTransformerType? Type { get; set; }
        public DateTime? VerificationDate { get; set; }
        public string? KTT { get; set; }
    }
}
