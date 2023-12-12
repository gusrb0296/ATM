using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DepositMoney : ATMManage
{
    // 현금 가격을 가져와야 함 


    public void DePositToATM(int money)
    {
        DepositBanlance(money);
    }
}
