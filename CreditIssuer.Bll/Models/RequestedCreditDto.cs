using Credit.Models;
using Newtonsoft.Json;

namespace CreditIssuer.Bll.Models
{
    public class RequestedCreditDto
    {
        public int Id { get; set; }
        public CreditType CreditType { get; set; }
        public long RequestedAmount { get; set; }
        public string RequestedCurrency { get; set; }
        public long AnnualSalary { get; set; }
        public long MonthlySalary { get; set; }
        public string CompanyName { get; set; }
        public string Comment { get; set; }
    }
}