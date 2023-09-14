using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    [SerializeField] public GameObject gameOverUI;
    // Start is called before the first frame update
    public void gameoverscreen()
    {
        gameOverUI.SetActive(true);
    }
}
