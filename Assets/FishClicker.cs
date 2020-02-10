using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FishClicker : MonoBehaviour
{
    private int money = 0;
    private int moneyPerClick = 1;

    public int Money
    {
        get => money;
        set
        {
            money = value;
            OnMoneyChanged?.Invoke(money);
        }
    }

    public int MoneyPerClick
    {
        get => moneyPerClick;
        set
        {
            moneyPerClick = value;
            OnMoneyPerClickChanged?.Invoke(moneyPerClick);
        }
    }

    public Action<int> OnFishClicked;
    public Action<int> OnMoneyChanged;
    public Action<int> OnMoneyPerClickChanged;

    private void OnMouseDown()
    {
        Money += moneyPerClick;
        OnFishClicked?.Invoke(moneyPerClick);
    }
}
