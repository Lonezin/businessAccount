
using Client.Entities;

namespace Business.Entities
{
    public class BusinessAccount : Account
    {
        public double LoanLimit { get; set; } 
        public BusinessAccount()
        {
        }
        public BusinessAccount(int number, string holder, double balance, double loanlimit) : base(number, holder, balance)
        {
            LoanLimit = loanlimit;
        } 
    }
}