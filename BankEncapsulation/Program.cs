using BankEncapsulation;

var account1 = new BankAccount();

Console.Write("Please enter deposit amount: ");
var userDepositAmount = double.Parse(Console.ReadLine());

account1.Deposit(userDepositAmount);

Console.WriteLine($"New Balance: {account1.GetBalance()}");