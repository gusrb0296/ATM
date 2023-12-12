using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using UnityEngine;

public class ATMManage : MonoBehaviour
{
    private int _balanceATM = 50000;
    private int _holdingMoney = 100000;

    public int GetBalanceMoney()
    {
        return _balanceATM;
    }

    public int GetHolddingMoney()
    {
        return _holdingMoney;
    }

    public void DepositBanlance(int money)
    {
        _balanceATM += money;
        Debug.Log(_balanceATM);
    }
}
