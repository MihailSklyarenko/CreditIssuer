using CreditIssuer.Bll.Interfaces;
using CreditIssuer.Bll.Models;
using CreditIssuer.Dal.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditIssuer.Bll.Services
{
    public class CreateRequestService : ICreateRequestService
    {
        IRequestRepository requestRepository;
        public CreateRequestService(IRequestRepository requestRepository)
        {
            this.requestRepository = requestRepository;
        }

        public async Task Create(CreditRequestDto creditRequestDto)
        {
            //mapper

            requestRepository.AddRequest(creditRequestDto);
        }
    }
}