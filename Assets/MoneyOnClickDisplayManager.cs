using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyOnClickDisplayManager : MonoBehaviour
{
    [SerializeField] private FishClicker fishClicker;

    private void Start()
    {
        fishClicker.OnFishClicked += OnFishClicked;
    }

    private void OnFishClicked(int money)
    {
        var display = transform.GetChild(0).GetComponent<MoneyOnClickDisplay>();
        display.Display(money);
        display.transform.SetAsLastSibling();
    }
}
