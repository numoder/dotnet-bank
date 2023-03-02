

BankAccount newaccount = new BankAccount();
// newaccount.customerName = "Jim";

if(newaccount.typeOfAccount == "checking") {
    // balance = balance + 100;
    newaccount.balance += 100;
}



Console.WriteLine(newaccount.customerName + "'s balance is $" + newaccount.balance);