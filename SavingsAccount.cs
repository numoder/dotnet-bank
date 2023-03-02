public class SavingsAccount : BankAccount {

    public SavingsAccount(string newCustomerName, double newBalance) : base(newCustomerName, newBalance) {

        this.deposit(200);
        
    }
}