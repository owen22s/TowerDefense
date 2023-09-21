using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerstats : MonoBehaviour
{
    static public int money;
     public int startmoney;
    static public int lives;
    public int startlives;
    public GameOver gameOver1;
  
    // Start is called before the first frame update
    void Start()
    {
        lives = startlives;
        money = startmoney;
    }
    private void Update()
    {
        if (lives < 1)
        {
            gameOver1.gameoverscreen();
        }
    }
}
