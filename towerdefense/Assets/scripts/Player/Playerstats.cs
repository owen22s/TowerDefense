using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class Playerstats : MonoBehaviour
{
    public static int money;
 
    public static int lives;

    public GameOver gameOver1;
    public UnityEvent OnLivesChanged;
    void Start()
    {
        lives = 20;
        money = 100;
    }

    public void EnemyDied()
    {
        money += 2;
    }

    public void DecreaseLives()
    {
        lives--;
    }

    void Update()
    {
        if (lives < 1)
        {
            gameOver1.gameoverscreen();
        }
    }
}
