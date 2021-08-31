using CreditIssuer.Models;

namespace CreditEvaluator.Bll.Interfaces
{
    public interface IService
    {
        Status Evaluate(CreditRequest creditRequest);
    }
}