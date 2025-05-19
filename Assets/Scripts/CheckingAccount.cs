// INHERITANCE
public class CheckingAccount : BankAccount
{
    public CheckingAccount(string accNum, float initial) : base(accNum, initial) { }

    // POLYMORPHISM
    public override string Withdraw(float amount)
    {
        float currentBalance = GetBalance();
        float newBalance = currentBalance - amount;

        if (newBalance >= -1000f)
        {
            Deposit(-amount);  // Same as subtracting
            return $"Withdrew {amount}. New balance: {GetBalance()}";
        }
        return "Overdraft limit exceeded.";
    }
}
