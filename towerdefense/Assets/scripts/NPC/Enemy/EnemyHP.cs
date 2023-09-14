using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyHP : MonoBehaviour
{
    public UnityEvent Die;
    public int hp;
    public int maxHP;
    [SerializeField] private Healthbar _healthbar;
    void Start()
    {
        maxHP = 100;
        hp = 100;
        _healthbar.UpdateHealthBar(maxHP,hp);
    }
        void OnTriggerEnter2D(Collider2D col, Collider2D other)
    {
        Debug.Log("test");

        if (other.gameObject.CompareTag("Wapen"))
        {
            hp -= 20;
            if (hp <= 0)
            {
                hp = 100;
                Die.Invoke();
            }
            else if (hp > maxHP)
            {
                hp = maxHP;
            }
            _healthbar.UpdateHealthBar(maxHP, hp);
        }
    }
}

