using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI HoldingMoneyText;
    public TextMeshProUGUI BalanceMoneyText;

    int HoldingMoney = 0;
    int BalanceMoney = 0;

    ATMManage ATM = new ATMManage();

    

    // Start is called before the first frame update
    void Start()
    {
       
        
    }

    // Update is called once per frame
    void Update()
    {
        HoldingMoney = ATM.GetHolddingMoney();
        BalanceMoney = ATM.GetBalanceMoney();
        HoldingMoneyText.text = HoldingMoney.ToString("C");
        BalanceMoneyText.text = BalanceMoney.ToString("C");
    }
}
