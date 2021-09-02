using Credit.Models;
using Newtonsoft.Json;

namespace CreditIssuer.Dal.Models
{
    public class RequestedCredit
    {
        public int Id { get; set; }
        [JsonProperty("CreditType")]
        public CreditType CreditType { get; set; }

        [JsonProperty("RequestedAmount")]
        public long RequestedAmount { get; set; }

        [JsonProperty("RequestedCurrency")]
        public string RequestedCurrency { get; set; }

        [JsonProperty("AnnualSalary")]
        public long AnnualSalary { get; set; }

        [JsonProperty("MonthlySalary")]
        public long MonthlySalary { get; set; }

        [JsonProperty("CompanyName")]
        public string CompanyName { get; set; }

        [JsonProperty("Comment")]
        public string Comment { get; set; }
    }
}