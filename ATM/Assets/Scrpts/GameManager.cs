using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using TMPro.EditorUtilities;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI HoldingMoneyText;
    public TextMeshProUGUI BalanceMoneyText;

    public GameObject LackOfMouneyPopUp;

    public TMP_InputField MoneyInputField;

    private void Start()
    {
        AllMoneyUpdate();
    }

    public void CheckEnoughWithdraw(int money)
    {
        if(MoneyManager.instance.userData.balance < money)
        {
            LackOfMouneyPopUp.SetActive(true);
            return;
        }
        else
        {
            Withdraw(money);
        }
    }
    public void CheckEnoughDeposit(int money)
    {
        if(MoneyManager.instance.userData.cash < money)
        {
            LackOfMouneyPopUp.SetActive(true);
            return;
        }
        else
        {
            Deposit(money);
        }
    }

    public void Deposit(int money)
    {
        MoneyManager.instance.userData.balance += money;
        MoneyManager.instance.userData.cash -= money;
        AllMoneyUpdate();
    }

    public void Withdraw(int money)
    {
        MoneyManager.instance.userData.balance -= money;
        MoneyManager.instance.userData.cash += money;
        AllMoneyUpdate();
    }

    string FormatNumber(int num)
    {
        return string.Format("{0:N0}", num);
    }
    public void AllMoneyUpdate()
    {
        BalanceMoneyText.text = FormatNumber(MoneyManager.instance.userData.balance);
        HoldingMoneyText.text = FormatNumber(MoneyManager.instance.userData.cash);
    }

    public void DepositInputFieldMoney()
    {
        //string money = MoneyInputField.text;
        //if(int.TryParse(money, out int num))
        //{
        //    CheckEnoughDeposit(Convert.ToInt32(money));
        //}
        int.TryParse(MoneyInputField.text, out int money);
        CheckEnoughDeposit(money);
    }

    public void WithdarwInputFieldMoney()
    {
        //string money = MoneyInputField.text;
        //if (int.TryParse(money, out int num))
        //{
        //    CheckEnoughWithdraw(Convert.ToInt32(money));
        //}
        int.TryParse(MoneyInputField.text, out int money);
        CheckEnoughWithdraw(money);
    }
}
