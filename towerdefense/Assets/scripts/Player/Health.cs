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
    public TMP_Text healthText;
    [SerializeField] public GameObject gameOverUI;
    public GameObject hurtcanvas;

    void Start()  
    {
        health = numOfHearts;
        healthText = GetComponent<TMP_Text>();

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        string tag = collision.gameObject.tag.ToLower().Trim();
        switch (tag)
        {
            case "enemy":
                health--;
                healthText.text = health.ToString();
                isHurt = true;
                hurtcanvas.SetActive(true);
                StartCoroutine(DeactivateHurtCanvas());

                if (health <= 0)
                {
                    gameOverUI.SetActive(true);
                    Time.timeScale = 0f;
                    
                }
                break;
        }
        IEnumerator DeactivateHurtCanvas()
        {
            yield return new WaitForSeconds(0.2f);
            hurtcanvas.SetActive(false);
            isHurt = false;
        }
    }
}

