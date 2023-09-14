using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public float health;
    public int numOfHearts;
    public Image[] heartImages;
    public Sprite fullHeart;
    public Sprite emptyHeart;
    public Vector3 spawnpoint;
    public DeathscreenUI gameManager;
    public GameObject hurtcanvas;

    private bool isHurt;

    void Update()
    {

        if (health > numOfHearts)
        {
            health = numOfHearts;
        }

        for (int i = 0; i < heartImages.Length; i++)
        {
            if (i < health)
            {
                heartImages[i].sprite = fullHeart;
            }
            else
            {
                heartImages[i].sprite = emptyHeart;
            }

            if (i < numOfHearts)
            {
                heartImages[i].enabled = true;
            }
            else
            {
                heartImages[i].enabled = false;
            }

        }


        for (int i = 0; i < heartImages.Length; i++)
        {
        }

        void OnCollisionEnter2D(Collision2D collision)
        {
            string tag = collision.gameObject.tag.ToLower().Trim();

            switch (tag)
            {
                case "spikes":
                case "enemy":
                    health -= 1;
                    Debug.Log("Health reduced! Current health: " + health);
                    Debug.Log("Collision occurred!");
                    ActivateHurtCanvas();
                    if (health <= 0)
                    {
                        gameManager.gameoverscreen();
                        Debug.Log("ded");
                        Time.timeScale = 0f;
                    }
                    break;
            }
        }
        void ActivateHurtCanvas()
        {
            if (!isHurt)
            {
                isHurt = true;
                hurtcanvas.SetActive(true);
                StartCoroutine(DeactivateHurtCanvas());
            }
        }

        IEnumerator DeactivateHurtCanvas()
        {
            yield return new WaitForSeconds(0.2f);
            hurtcanvas.SetActive(false);
            isHurt = false;
        }
    }
}
