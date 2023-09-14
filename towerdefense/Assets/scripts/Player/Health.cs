using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public float health;
    public int numOfHearts;
    private bool isHurt;
    public Text healthText;

    void Start()  
    {
        health = numOfHearts;
        healthText = GetComponent<Text>();

    }
    void OnCollisionEnter2D(Collision2D collision, HurtCanvas hurtCanvas, GameOver gameOver)
    {
        string tag = collision.gameObject.tag.ToLower().Trim();

        switch (tag)
        {
            case "spikes":
            case "enemy":
                health--;
                healthText.text = health.ToString();
                Debug.Log("Health reduced! Current health: " + health);
                Debug.Log("Collision occurred!");
                hurtCanvas.ActivateHurtCanvas();
                if (health <= 0)
                {
                    gameOver.gameoverscreen();
                    Debug.Log("ded");
                    Time.timeScale = 0f;
                }
                break;
        }
    }
}
