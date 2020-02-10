using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Upgrade : MonoBehaviour
{
    public void AddUpgrade(Action onClick)
    {
        GetComponent<Button>().onClick.AddListener(() => onClick());
    }
}
