using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] public Transform target;
    [SerializeField] private float speed = 10;

    void Update()
    {
        if (target == null)
        {
            Destroy(gameObject);
            return;
        }

        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, Time.deltaTime * speed);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            Destroy_on_hit destroyOnHitScript = other.GetComponent<Destroy_on_hit>();

            if (destroyOnHitScript != null && destroyOnHitScript.EnemyHit)
            { 

                destroyOnHitScript.EnemyHit = false;
            }
            Debug.Log("HIT");
  
            Destroy(gameObject);
        }
    }
}