using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyPerSecDisplay : MonoBehaviour
{
    [SerializeField] private AutoClickManager autoClicker;

    private Text text;

    private void Start()
    {
        autoClicker.OnMoneyPerSecChanged += OnMoneyPerSecChanged;
        text = GetComponent<Text>();
    }

    private void OnMoneyPerSecChanged(int mps)
    {
        text.text = $"MPS: {mps}";

    }
}
