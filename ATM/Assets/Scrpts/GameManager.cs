using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using TMPro.EditorUtilities;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public TextMeshProUGUI HoldingMoneyText;
    public TextMeshProUGUI BalanceMoneyText;

    public GameObject LackOfMouneyPopUp;

    public TMP_InputField MoneyInputField;


    public static int HoldingMoney = 100000;
    public static int BalanceMoney = 50000;


    private void Awake()
    {
        instance = this;
        AllMoneyUpdate();
    }

    public void CheckEnoughWithdraw(int money)
    {
        if(BalanceMoney < money)
        {
            LackOfMouneyPopUp.SetActive(true);
        }
        else
        {
            Withdraw(money);
        }
    }
    public void CheckEnoughDeposit(int money)
    {
        if(HoldingMoney < money)
        {
            LackOfMouneyPopUp.SetActive(true);
        }
        else
        {
            Deposit(money);
        }
    }

    public void Deposit(int money)
    {
        BalanceMoney += money;
        HoldingMoney -= money;
        AllMoneyUpdate();
    }

    public void Withdraw(int money)
    {
        BalanceMoney -= money;
        HoldingMoney += money;
        AllMoneyUpdate();
    }

    public void AllMoneyUpdate()
    {
        BalanceMoneyText.text = BalanceMoney.ToString("C");
        HoldingMoneyText.text = HoldingMoney.ToString("C"); 
    }

    public void DepositInputFieldMoney()
    {
        string money = MoneyInputField.text;
        if(int.TryParse(money, out int num))
        {
            CheckEnoughDeposit(Convert.ToInt32(money));
        }
    }

    public void WithdarwInputFieldMoney()
    {
        string money = MoneyInputField.text;
        if (int.TryParse(money, out int num))
        {
            CheckEnoughWithdraw(Convert.ToInt32(money));
        }
    }
}
