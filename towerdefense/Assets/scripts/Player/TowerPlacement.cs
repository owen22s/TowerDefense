using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerPlacement : MonoBehaviour
{
    [SerializeField] private Tower towerPrefab;
    [SerializeField] private TowerSlot[] towerSlots;
    [SerializeField] public int TowerPrice = 10;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero);

            if (hit.collider != null && Playerstats.money >= TowerPrice)
            {
                int towerSlotIndex = Array.IndexOf(towerSlots, hit.collider.GetComponent<TowerSlot>());
                Playerstats.money -= TowerPrice;
                TowerPrice *= 2;
                TowerPrice -= 10;
                if (towerSlotIndex != -1)
                {
                    if (towerSlots[towerSlotIndex].tower != null)
                    {
                        return;
                    }

                    PlaceTower(towerSlotIndex);
                }
            }
        }
    }

    void PlaceTower(int towerSlotIndex)
    {
        Tower tower = Instantiate(towerPrefab);
        towerSlots[towerSlotIndex].tower = tower;
        tower.transform.position = towerSlots[towerSlotIndex].transform.position;
    }

}