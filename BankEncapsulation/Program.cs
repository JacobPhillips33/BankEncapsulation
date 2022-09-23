using BankEncapsulation;

var account1 = new BankAccount();

Console.Write("Please enter deposit amount: $");

double userDepositAmount;
var userDepositValid = double.TryParse(Console.ReadLine(), out userDepositAmount);

while (!userDepositValid)
{
    Console.Write("Invalid entry. Please enter valid deposit amount: $");
    userDepositValid = double.TryParse(Console.ReadLine(), out userDepositAmount);
}

account1.Deposit(userDepositAmount);

Console.WriteLine($"New Balance: ${account1.GetBalance()}");