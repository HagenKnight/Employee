namespace Payroll.Domain
{
    public class ApiResp<T>
    {
        public string Status { get; set; } = string.Empty;
        public T? Data { get; set; }
        public string Message { get; set; } = string.Empty;
    }

}
