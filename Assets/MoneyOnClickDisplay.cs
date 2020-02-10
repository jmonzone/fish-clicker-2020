using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyOnClickDisplay : MonoBehaviour
{
    private Vector3 targetPosition = Vector3.zero;
    private Text text;

    private void Start()
    {
        text = GetComponent<Text>();
        gameObject.SetActive(false);
    }

    private void Update()
    {
        if (transform.position.y < targetPosition.y)
        {
            transform.position += Vector3.up * Time.deltaTime * 75.0f;
        }
        else
        {
            gameObject.SetActive(false);
        }
    }

    public void Display(int money)
    {
        gameObject.SetActive(true);
        text.text = $"+{money}";
        transform.position = Input.mousePosition;
        targetPosition = transform.position + Vector3.up * 50.0f;
    }
}
