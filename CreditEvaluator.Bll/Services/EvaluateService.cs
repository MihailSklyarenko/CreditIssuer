using CreditEvaluator.Bll.Interfaces;
using CreditEvaluator.Bll.Models;
using CreditIssuer.Models;

namespace CreditEvaluator.Bll.Services
{
    public class EvaluateService : IService
    {
        public Status Evaluate(CreditRequest creditRequest)
        {
            Status result = new Status();

            result.ScoringStatus = ((creditRequest.RequestedCredit.AnnualSalary * 5) - creditRequest.RequestedCredit.RequestedAmount) > 0;

            return result;
        }
    }
}