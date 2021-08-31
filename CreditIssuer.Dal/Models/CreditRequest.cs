using Credit.Models;
using System;

namespace CreditIssuer.Dal.Models
{
    public class CreditRequest
    {
        public int Id { get; set; }
        public string ApplicationNum { get; set; }
        public DateTimeOffset ApplicationDate { get; set; }
        public string BranchBank { get; set; }
        public string BranchBankAddr { get; set; }
        public CreditManager CreditManagerId { get; set; }
        public Applicant Applicant { get; set; }
        public RequestedCredit RequestedCredit { get; set; }
    }

    public class CreditManager
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
    }

    public class Applicant
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTimeOffset DateBirth { get; set; }
        public string CityBirth { get; set; }
        public string AddressBirth { get; set; }
        public string AddressCurrent { get; set; }
        public int Inn { get; set; }
        public int Snils { get; set; }
        public string PassportNum { get; set; }
    }

    public class RequestedCredit
    {
        public int Id { get; set; }
        public CreditType CreditType { get; set; }
        public long RequestedAmount { get; set; }
        public string RequestedCurrency { get; set; }
        public long AnnualSalary { get; set; }
        public long MonthlySalary { get; set; }
        public string CompanyName { get; set; }
        public string Comment { get; set; }
    }
}