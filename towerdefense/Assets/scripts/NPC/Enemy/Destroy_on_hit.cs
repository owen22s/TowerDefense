using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_on_hit : MonoBehaviour
{
    [SerializeField] public bool EnemyHit;
    public void Start()
    {
        EnemyHit= true;
    }
    public void Update()
    {
        
    }
}
