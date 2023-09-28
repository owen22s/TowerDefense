using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TowerPriceText : MonoBehaviour
{
    public Text text;
    public TowerPlacement towerPlacement;

    void Start()
    {
        towerPlacement = FindObjectOfType<TowerPlacement>();

        if (towerPlacement != null)
        {
            text.text = "Tower Price: " + towerPlacement.TowerPrice.ToString();
        }
    }

    void Update()
    {
        if (towerPlacement != null)
        {
            text.text = "Tower Price: " + towerPlacement.TowerPrice.ToString();
        }
    }
}
