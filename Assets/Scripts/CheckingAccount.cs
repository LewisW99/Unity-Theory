public class CheckingAccount : BankAccount
{
    public CheckingAccount(string accNum, float initial) : base(accNum, initial) { }

    public override string Withdraw(float amount)
    {
        float balance = GetBalance();
        if (amount <= balance + 100)  // Overdraft allowed
        {
            Deposit(-amount);  // Reuse method
            return $"Withdrew {amount} with overdraft. New balance: {GetBalance()}";
        }
        return "Overdraft limit reached.";
    }
}
