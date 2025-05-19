using UnityEngine;
using TMPro;

public class AccountManager : MonoBehaviour
{
    private BankAccount currentAccount;

    public TMP_InputField amountInput;
    public TextMeshProUGUI balanceText;

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
        if (currentAccount != null)
        {
            float balance = currentAccount.GetBalance();
            balanceText.text = $"Balance: ${balance}";

            if (balance < 0)
            {
                balanceText.color = Color.red;
            }
            else
            {
                balanceText.color = Color.black;
            }
        }
    }
}
