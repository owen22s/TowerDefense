using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MoneyText : MonoBehaviour
{
    public Text text;
    void Update()
    {
        text.text = Playerstats.money.ToString();
    }
}