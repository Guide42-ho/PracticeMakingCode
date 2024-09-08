public class BankAccountTest {

    public static void main(String[] args) {
        try {
            BankAccount account = new BankAccount("0411200000", "Karina Bluu", 1000.0);
            account.checkBalance();
            account.deposit(500.0);
            account.checkBalance();
            account.withdraw(200.0);
            account.checkBalance();
            account.withdraw(2000.0);  // Should print an error message
            account.checkBalance();
 
            // Testing setter and getter
            account.setAccountHolderName("Yu Jimin");
            System.out.println("Account Holder Name: " + account.getAccountHolderName());
        } catch (IllegalArgumentException e) {
            System.out.println(e.getMessage());
        }
 
        try {
            BankAccount invalidAccount = new BankAccount("12345", "Invalid Account", 400.0);
        } catch (IllegalArgumentException e) {
            System.out.println(e.getMessage());
        }
    }
}
