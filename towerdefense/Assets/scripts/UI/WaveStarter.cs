using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaveStarter : MonoBehaviour
{
    public GameObject StartwaveButton;
    public EnemySpawner2 EnemySpawner;
    public void ShowStartWave()
    {
        StartwaveButton.SetActive(true);
    }
    public void StartWave()
    {
        StartwaveButton.SetActive(false);
        EnemySpawner.StartCoroutine(EnemySpawner.StartWave());
    }

}