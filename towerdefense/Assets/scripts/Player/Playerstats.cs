using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Playerstats : MonoBehaviour
{
    public static int money; 
    public int startmoney;
    public static int lives;
    public int startlives;
    public GameOver gameOver1;
    public UnityEvent OnLivesChanged = new UnityEvent();
    void Start()
    {
        lives = startlives;
        money = startmoney;
    }

    public void DecreaseLives()
    {
        lives--;
    }
    
        void Update()
    {
        waypointfollower.OnReachedEnd.AddListener(DecreaseLives);
        if (lives < 1)
        {
            gameOver1.gameoverscreen();
            
        }
    }
}
