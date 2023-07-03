using Microsoft.Extensions.Logging;
using System.Runtime.Serialization;

namespace Payroll.Application.Exceptions.Api
{
    public class ExternalApiException : Exception
    {
        public int Code { get; set; }
        public string Details { get; set; }
        public LogLevel LogLevel { get; set; }

        public ExternalApiException(int code, string message = null, string details = null,
                                 Exception innerException = null, LogLevel logLevel = LogLevel.Warning)
            : base(message, innerException) { Code = Convert.ToInt32(code); Details = details; LogLevel = logLevel; }

        public ExternalApiException(SerializationInfo serializationInfo, StreamingContext context)
            : base(serializationInfo, context) { }
        public ExternalApiException WithData(string name, object value) { Data[name] = value; return this; }

    }
}
