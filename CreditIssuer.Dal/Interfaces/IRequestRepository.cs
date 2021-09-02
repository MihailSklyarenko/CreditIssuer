using CreditIssuer.Dal.Models;
using System.Threading.Tasks;

namespace CreditIssuer.Dal.Interfaces
{
    public interface IRequestRepository
    {
        Task AddRequest(CreditRequest creditRequest);
    }
}