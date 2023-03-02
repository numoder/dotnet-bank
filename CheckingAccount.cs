public class CheckingAccount : BankAccount {
    public CheckingAccount(string newCustomerName, double newBalance) : base(newCustomerName, newBalance) {

        // this.balance =+ 100; ALL checking accounts created get $100 dollars more in their balance
        this.deposit(100); 
    }

}