using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerstats : MonoBehaviour
{
    public static int money; 
    public int startmoney;
    public static int lives;
    public int startlives;
    public GameOver gameOver1;

    void Start()
    {
        lives = startlives;
        money = startmoney;
    }

    void Update()
    {
        if (lives < 1)
        {
            gameOver1.gameoverscreen();
            
        }
    }
}
