using CreditIssuer.Dal.Database;
using CreditIssuer.Dal.Interfaces;
using CreditIssuer.Dal.Models;
using System.Threading.Tasks;

namespace CreditIssuer.Dal.Repositories
{
    public class RequestRepository : IRequestRepository
    {
        public async Task AddRequest(CreditRequest creditRequest)
        {
            using (DatabaseContext database = new DatabaseContext())
            {
                database.CreditRequests.Add(creditRequest);
                await database.SaveChangesAsync();
            }
        }
    }
}