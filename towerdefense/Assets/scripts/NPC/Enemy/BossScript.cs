using UnityEngine;
using UnityEngine.Events;

public class BossScript : MonoBehaviour
{

    public UnityEvent onBossDestroy = new UnityEvent();

 
    public void DestroyBoss()
    {
        Debug.Log("Boss Destroyed");
        onBossDestroy.Invoke();
    }
}
