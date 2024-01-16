using Client.Entities;

namespace Main
{
    class Program
    {
        static void Main (string[] args)
        {
            Account account = new Account (2032, "Alex", 5000.00);
            System.Console.WriteLine(account);
            BusinessAccount bacc = new BusinessAccount(100, "Vini", 20000.00, 300000.0);
            System.Console.WriteLine(bacc);
            
        }
    }
}