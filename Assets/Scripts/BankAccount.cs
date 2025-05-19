public class BankAccount
{
    // ENCAPSULATION
    private string accountNumber;
    private float balance;

    public BankAccount(string accountNumber, float initialBalance)
    {
        this.accountNumber = accountNumber;
        this.balance = initialBalance;
    }

    // POLYMORPHISM
    public virtual string Withdraw(float amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
            return $"Withdrew {amount}. New balance: {balance}";
        }
        return "Insufficient funds.";
    }

    // ABSTRACTION
    public void Deposit(float amount)
    {
        balance += amount;
    }

    // ENCAPSULATION
    public float GetBalance() => balance;

    // ENCAPSULATION
    public string GetAccountNumber() => accountNumber;
}
