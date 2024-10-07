using System.Runtime.Serialization;

namespace TransNeftEnergo.Core.Responses
{
    public class ResponseStatus
    {
        public ErrorCode ErrorCode { get; set; } = ErrorCode.Success;

        public string? ErrorDescription { get; set; }
    }
    [DataContract]
    [Flags]
    public enum ErrorCode
    {
        [EnumMember]
        Success,
        [EnumMember]
        InternalError
    }
}
