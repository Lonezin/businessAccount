using Client.Entities;

namespace Main
{
    class Program
    {
        static void Main (string[] args)
        {
            Account account = new Account (2032, "Alex", 5000.00);
            BusinessAccount businesAccount = new BusinessAccount(350, "CIA", 20000.05, 9000000);
            System.Console.WriteLine(account);
            System.Console.WriteLine(businesAccount);
        }
    }
}