namespace Client.Entities
{
    public class SavingsAccount : Account
    {
        public double InterstRate { get; set; }
        public SavingsAccount()
        {

        }
        public SavingsAccount(int number, string holder, double balance, double interstRate) : base(number, holder, balance)
        {
            InterstRate = interstRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterstRate;
        }
    }
}