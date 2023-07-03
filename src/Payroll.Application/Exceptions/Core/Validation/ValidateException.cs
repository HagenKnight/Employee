using FluentValidation.Results;

namespace Payroll.Application.Exceptions
{
    public class ValidateException : ApplicationException
    {
        public IReadOnlyDictionary<string, string[]> ErrorsDictionary { get; }
        public ValidateException(IReadOnlyDictionary<string, string[]> errorDictionary) :
          base(">>> One or more validation errors occurred") => ErrorsDictionary = errorDictionary;
    }
}
