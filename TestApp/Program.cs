using CreditIssuer.Dal.Database;
using System;
using System.Linq;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                var a = context.Applicants.ToList();
            }


            Console.ReadLine();
        }
    }
}
