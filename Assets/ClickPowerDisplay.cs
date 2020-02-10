using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickPowerDisplay : MonoBehaviour
{
    [SerializeField] private FishClicker fish;

    private Text text;

    private void Start()
    {
        fish.OnMoneyPerClickChanged += OnMoneyPerClickChanged;
        text = GetComponent<Text>();
    }

    private void OnMoneyPerClickChanged(int clickPower)
    {
        text.text = $"Click Power: {clickPower}";

    }
}
