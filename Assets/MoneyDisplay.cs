using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyDisplay : MonoBehaviour
{
    [SerializeField] private FishClicker fish;

    private Text text;

    private void Start()
    {
        fish.OnMoneyChanged += OnMoneyChanged;
        text = GetComponent<Text>();
    }

    private void OnMoneyChanged(int money)
    {
        text.text = $"Money: {money}";

    }
}
