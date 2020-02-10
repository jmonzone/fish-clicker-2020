using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoClickManager : MonoBehaviour
{
    [SerializeField] private FishClicker fish;

    private int moneyPerSec = 0;

    public int MoneyPerSec
    {
        get => moneyPerSec;
        set
        {
            moneyPerSec = value;
            OnMoneyPerSecChanged?.Invoke(moneyPerSec);
        }
    }

    public Action<int> OnMoneyPerSecChanged;

    private void Start()
    {
        StartCoroutine(AutoClick());
    }



    private IEnumerator AutoClick()
    {
        while (true)
        {
            fish.Money += moneyPerSec;
            yield return new WaitForSeconds(1.0f);
        }
    }
}
