
BankAccount newaccount = 
new SavingsAccount("Jim",250);


Console.WriteLine(newaccount.customerName + "'s balance is $" + newaccount.getBalance());


// he added 100 more
newaccount.deposit(100);


Console.WriteLine(newaccount.customerName + "'s balance is $" + newaccount.getBalance());
