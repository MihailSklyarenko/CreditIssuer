using Newtonsoft.Json;
using System;

namespace CreditIssuer.Bll.Models
{
    public class ApplicantDto
    {
        public int Id { get; set; }
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
}