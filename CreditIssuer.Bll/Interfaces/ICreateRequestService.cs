using CreditIssuer.Bll.Models;
using System.Threading.Tasks;

namespace CreditIssuer.Bll.Interfaces
{
    public interface ICreateRequestService
    {
        Task Create(CreditRequestDto creditRequestDto);
    }
}