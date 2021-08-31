using Credit.Models;
using Newtonsoft.Json;
using System;

namespace CreditIssuer.Models
{
    public partial class CreditRequest
    {
        [JsonProperty("ApplicationNum")]
        public string ApplicationNum { get; set; }

        [JsonProperty("ApplicationDate")]
        public DateTimeOffset ApplicationDate { get; set; }

        [JsonProperty("BranchBank")]
        public string BranchBank { get; set; }

        [JsonProperty("BranchBankAddr")]
        public string BranchBankAddr { get; set; }

        [JsonProperty("CreditManagerId")]
        public long CreditManagerId { get; set; }

        [JsonProperty("Applicant")]
        public Applicant Applicant { get; set; }

        [JsonProperty("RequestedCredit")]
        public RequestedCredit RequestedCredit { get; set; }
    }

    public partial class Applicant
    {
        [JsonProperty("FirstName")]
        public string FirstName { get; set; }

        [JsonProperty("MiddleName")]
        public string MiddleName { get; set; }

        [JsonProperty("LastName")]
        public string LastName { get; set; }

        [JsonProperty("DateBirth")]
        public DateTimeOffset DateBirth { get; set; }

        [JsonProperty("CityBirth")]
        public string CityBirth { get; set; }

        [JsonProperty("AddressBirth")]
        public string AddressBirth { get; set; }

        [JsonProperty("AddressCurrent")]
        public string AddressCurrent { get; set; }

        [JsonProperty("INN")]
        public long Inn { get; set; }

        [JsonProperty("SNILS")]
        public long Snils { get; set; }

        [JsonProperty("PassportNum")]
        public string PassportNum { get; set; }
    }

    public partial class RequestedCredit
    {
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