using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Lifetext : MonoBehaviour
{
public Text text;
    void Update()
    {
        text.text = Playerstats.lives.ToString();
    }
}
