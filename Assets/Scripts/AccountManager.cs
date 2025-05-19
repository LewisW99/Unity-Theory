using UnityEngine;
using UnityEngine.UI;

public class AccountManager : MonoBehaviour
{
    private BankAccount currentAccount;

    public InputField amountInput;
    public Text balanceText;

    public void CreateCheckingAccount()
    {
        currentAccount = new CheckingAccount("CHK001", 500);
        UpdateBalanceUI();
    }

    public void Deposit()
    {
        float amount = float.Parse(amountInput.text);
        currentAccount.Deposit(amount);
        UpdateBalanceUI();
    }

    public void Withdraw()
    {
        float amount = float.Parse(amountInput.text);
        string result = currentAccount.Withdraw(amount);
        Debug.Log(result);
        UpdateBalanceUI();
    }

    private void UpdateBalanceUI()
    {
        balanceText.text = $"Balance: {currentAccount.GetBalance()}";
    }
}

