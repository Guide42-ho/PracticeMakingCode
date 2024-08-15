public class BankAccount {
    private String accountNumber;
    private String accountHolderName;
    private double balance;

    public BankAccount(String accountNumber, String accountHolderName, double initialBalance) {
        if (accountNumber.length() == 10) {
            this.accountNumber = accountNumber;
        } else {
            throw new IllegalArgumentException("Account number must be 10 digits.");
        }

        if (initialBalance >= 500) {
            this.balance = initialBalance;
        } else {
            System.out.println("Initial balance must be at least 500.");
        }

        this.accountHolderName = accountHolderName;
    }

    public void deposit(double amount) {
        if (amount > 0) {
            balance += amount;
            System.out.println("Deposit: "+amount);
        } else {
            System.out.println("Deposit amount must be positive.");
        }
        
    }

    public void withdraw(double amount) {
        if (amount > 0 && amount <= balance) {
            balance -= amount;
            System.out.println("Withdraw: "+amount);
        } else {
            System.out.println("Withdrawal amount must be positive and not exceed current balance.");
        }
        
    }

    public void checkBalance() {
        System.out.println("Current balance: " + balance);
    }

    public String getAccountNumber() {
        return accountNumber;
    }

    public String getAccountHolderName() {
        return accountHolderName;
    }

    public double getBalance() {
        return balance;
    }

    public void setAccountHolderName(String accountHolderName) {
        this.accountHolderName = accountHolderName;
    }
}
