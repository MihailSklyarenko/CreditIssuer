using System;

namespace CreditIssuer.Bll.Models
{
    public partial class CreditRequestDto
    {
        public int Id { get; set; }
        public string ApplicationNum { get; set; }
        public DateTimeOffset ApplicationDate { get; set; }
        public string BranchBank { get; set; }
        public string BranchBankAddr { get; set; }
        public int CreditManagerId { get; set; }
        public ApplicantDto Applicant { get; set; }
        public RequestedCreditDto RequestedCredit { get; set; }
    }
}