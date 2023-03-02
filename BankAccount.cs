public class BankAccount {

    public string customerName = "";
    public double balance = 0.00;


    public BankAccount(string newCustomerName, double newBalance){
        customerName = newCustomerName;
        balance = newBalance;
    }

    public void deposit(double amount) {
        balance += amount;
    }public double getBalance() {
        return balance;
    }



}