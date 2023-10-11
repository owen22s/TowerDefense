using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerPlacement : MonoBehaviour
{
    [SerializeField] private Tower towerPrefab;
    [SerializeField] private TowerSlot[] towerSlots;
    [SerializeField] public int TowerPrice = 10;
    [SerializeField] public int UpgradeCost = 20;  // Added UpgradeCost variable
    public Sprite Archer_upgrade;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero);

            if (hit.collider != null)
            {
                int towerSlotIndex = Array.IndexOf(towerSlots, hit.collider.GetComponent<TowerSlot>());

                if (towerSlotIndex != -1 && towerSlots[towerSlotIndex].tower == null)
                {
                    PlaceTower(towerSlotIndex);
                }
                else if (towerSlotIndex != -1 && towerSlots[towerSlotIndex].tower != null)
                {
                    Tower selectedTower = towerSlots[towerSlotIndex].tower;
                    if (!selectedTower.Upgraded && Playerstats.money >= UpgradeCost)
                    {
                        selectedTower.UpgradeTower();
                        Playerstats.money -= UpgradeCost;
                    }
                }
            }
        }
    }

    void PlaceTower(int towerSlotIndex)
    {
        if (Playerstats.money < TowerPrice) return;

        Playerstats.money -= TowerPrice;
        TowerPrice *= 2;
        TowerPrice -= 10;

        Tower tower = Instantiate(towerPrefab);
        towerSlots[towerSlotIndex].tower = tower;
        tower.transform.position = towerSlots[towerSlotIndex].transform.position;
    }
}
