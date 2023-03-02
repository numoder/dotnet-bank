public class CheckingAccount : BankAccount {
    public CheckingAccount(string newCustomerName, double newBalance) : base(newCustomerName, newBalance) {

        balance =+ 100; // ALL checking accounts created get $100 dollars more in ther balance
        customerName = newCustomerName;
    }

}