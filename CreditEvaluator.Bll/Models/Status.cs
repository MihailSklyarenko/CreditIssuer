using Newtonsoft.Json;

namespace CreditEvaluator.Bll.Models
{
    public class Status
    {
        [JsonProperty("ScoringStatus")]
        public bool ScoringStatus { get; set; }
    }
}