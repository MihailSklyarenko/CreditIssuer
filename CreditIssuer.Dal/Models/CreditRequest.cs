using Newtonsoft.Json;
using System;

namespace CreditIssuer.Dal.Models
{
    public partial class CreditRequest
    {
        public int Id { get; set; }
        [JsonProperty("ApplicationNum")]
        public string ApplicationNum { get; set; }

        [JsonProperty("ApplicationDate")]
        public DateTimeOffset ApplicationDate { get; set; }

        [JsonProperty("BranchBank")]
        public string BranchBank { get; set; }

        [JsonProperty("BranchBankAddr")]
        public string BranchBankAddr { get; set; }

        [JsonProperty("CreditManagerId")]
        public int CreditManagerId { get; set; }

        [JsonProperty("Applicant")]
        public Applicant Applicant { get; set; }

        [JsonProperty("RequestedCredit")]
        public RequestedCredit RequestedCredit { get; set; }
    }
}