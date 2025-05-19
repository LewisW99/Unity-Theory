public class BankAccount
{
    private string accountNumber;
    private float balance;

    public BankAccount(string accountNumber, float initialBalance)
    {
        this.accountNumber = accountNumber;
        this.balance = initialBalance;
    }

    public virtual string Withdraw(float amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
            return $"Withdrew {amount}. New balance: {balance}";
        }
        return "Insufficient funds.";
    }

    public void Deposit(float amount)
    {
        balance += amount;
    }

    public float GetBalance() => balance;
    public string GetAccountNumber() => accountNumber;
}
