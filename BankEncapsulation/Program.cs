using BankEncapsulation;

var account1 = new BankAccount();

var userEntry = "1";
while (userEntry == "1")
{
    Console.WriteLine("Would you like to make a deposit, make a withdrawl, or get your balance?");
    Console.Write("(Enter 1 for Deposit, 2 for Withdrawl, or 3 to Get Balance. Enter any other key to exit.) ");
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
                        
        userEntry = "1";
    }
    if (userEntry == "3")
    {
        Console.WriteLine($"Balance: ${account1.GetBalance()}");
        Console.WriteLine();

        userEntry = "1";
    }
}




