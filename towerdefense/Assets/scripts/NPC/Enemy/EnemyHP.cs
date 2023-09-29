using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyHP : MonoBehaviour
{
    public int hp;
    public int maxHP;
    [SerializeField] private Healthbar _healthbar;
    void Start()
    {
        _healthbar.UpdateHealthBar(maxHP,hp);
    }
        void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PROJECTTILE"))
        {
            Debug.Log(hp);
            hp -= 30;
            if (hp <= 0)
            {
                Destroy(gameObject);
                Playerstats.money += 2;
                EnemySpawner2.onEnemyDestroy.Invoke();

            }
            _healthbar.UpdateHealthBar(maxHP, hp);
        }
    }
}

