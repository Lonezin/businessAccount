using Client.Entities;

namespace Main
{
    class Program
    {
        static void Main (string[] args)
        {
            Account account = new Account (2032, "Alex", 5000.00);
            System.Console.WriteLine(account);
        }
    }
}