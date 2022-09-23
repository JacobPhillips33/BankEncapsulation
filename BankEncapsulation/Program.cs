using BankEncapsulation;

var account1 = new BankAccount();

string userEntry = "1";
while (userEntry == "1")
{
    Console.WriteLine("Would you like to make a Deposit or Withdrawl?");
    Console.Write("(Enter 1 for Deposit or 2 for Withdrawl) ");
    userEntry = Console.ReadLine();
    Console.WriteLine();

    if (userEntry == "1")
    {                     
        Console.Write("Please enter deposit amount: $");

        var userDepositValid = double.TryParse(Console.ReadLine(), out double userDepositAmount);
        Console.WriteLine();

        while (!userDepositValid)
        {
            Console.Write("Invalid entry. Please enter valid deposit amount: $");
            userDepositValid = double.TryParse(Console.ReadLine(), out userDepositAmount);
            Console.WriteLine();
        }

        account1.Deposit(userDepositAmount);

        Console.WriteLine($"New Balance: ${account1.GetBalance()}");
        Console.WriteLine();        
    }
    if (userEntry == "2")
    {
        Console.Write("Please enter withdrawl amount: $");

        var userWithrawlValid = double.TryParse(Console.ReadLine(), out double userWithrawlAmount);
        Console.WriteLine();

        while (!userWithrawlValid)
        {
            Console.Write("Invalid entry. Please enter valid withdrawl amount: $");
            userWithrawlValid = double.TryParse(Console.ReadLine(), out userWithrawlAmount);
            Console.WriteLine();
        }

        account1.Withdrawl(userWithrawlAmount);

        Console.WriteLine($"New Balance: ${account1.GetBalance()}");
        Console.WriteLine();
                
        userEntry = "1";
    }
}




