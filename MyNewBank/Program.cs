using MyNewBank;


var account = new BankAccount("Yaseen",1000);
var secondAccount = new BankAccount("Jason",20000);
Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");
Console.WriteLine($"Account {secondAccount.Number} was created for {secondAccount.Owner} with {secondAccount.Balance} initial balance.");