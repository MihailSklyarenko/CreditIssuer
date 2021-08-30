using CreditEvaluator.Bll.Models;
using CreditIssuer.Models;

namespace CreditEvaluator.Bll.Interfaces
{
    public interface IService
    {
        Status Evaluate(CreditRequest creditRequest);
    }
}