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
    public Vector3 spawnpostion;

    void Start()
    {
        maxHP = 100;
        hp = 100;

        _healthbar.UpdateHealthBar(maxHP,hp);
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("test");

        if (other.gameObject.CompareTag("Wapen"))
        {
            hp -= 20;
            if (hp <= 0)
            {
                hp = 100;
                Die.Invoke();
                transform.position = spawnpostion;
            }
            else if (hp > maxHP)
            {
                hp = maxHP;
            }
            Debug.Log(hp);
            _healthbar.UpdateHealthBar(maxHP, hp);
        }
        else if (other.gameObject.CompareTag("PowerUp"))
        {
            hp += 30;
            if (hp > maxHP)
            {
                hp = maxHP;
            }
            Debug.Log(hp);
            Destroy(other.gameObject);
            _healthbar.UpdateHealthBar(maxHP, hp);
        }

    }
}

