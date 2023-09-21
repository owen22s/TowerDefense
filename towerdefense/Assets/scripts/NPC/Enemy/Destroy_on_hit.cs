using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_on_hit : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision) 
    {
        switch (tag) 
        {
            case "castle":
                Destroy(gameObject);
                break;
        }
    }
}
