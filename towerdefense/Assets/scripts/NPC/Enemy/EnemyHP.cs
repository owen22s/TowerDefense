using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class EnemyHP : MonoBehaviour
{
    public int hp;
    public int maxHP;
    private Healthbar healthbar;
    public UnityEvent OnDestroy;

    void Start()
    {
        healthbar = GetComponent<Healthbar>();
        hp = maxHP;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PROJECTTILE"))
        {
            Debug.Log(hp);
            hp -= 30;
            healthbar.healthbar.fillAmount = Map(hp, 0, maxHP, 0, 1);
            if (hp <= 0)
            {
                OnDestroy.Invoke();
                Destroy(gameObject);
            }
        }
    }

    float Map(float s, float a1, float a2, float b1, float b2)
    {
        return b1 + (s - a1) * (b2 - b1) / (a2 - a1);
    }
}
