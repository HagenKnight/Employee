using System.Globalization;

namespace Payroll.Domain.Exceptions.Api
{
    public class ExternalApiException : Exception
    {
        public ExternalApiException() : base() { }
        public ExternalApiException(string message) : base(message) { }
        public ExternalApiException(string message, params object[] args)
            : base(string.Format(CultureInfo.CurrentCulture, $"External API Exception: {message}", args)) { }
    }
}
