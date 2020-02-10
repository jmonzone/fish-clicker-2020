using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeManager : MonoBehaviour
{
    [SerializeField] private FishClicker fish;
    [SerializeField] private AutoClickManager autoClicker;

    private int upgradeCost = 10;

    private void Start()
    {
        var upgradeButton1 = transform.GetChild(0).GetComponent<Upgrade>();
        upgradeButton1.AddUpgrade(() =>
        {
            if (fish.Money >= upgradeCost)
            {
                fish.MoneyPerClick++;
                fish.Money -= upgradeCost;
                upgradeCost += 10;
            }
        });

        var upgradeButton2 = transform.GetChild(1).GetComponent<Upgrade>();
        upgradeButton2.AddUpgrade(() =>
        {
            if (fish.Money >= upgradeCost)
            {
                autoClicker.MoneyPerSec++;
                fish.Money -= upgradeCost;
                upgradeCost += 10;
            }
        });

    }

}
