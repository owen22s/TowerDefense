using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HurtCanvas : MonoBehaviour
{

    public GameObject hurtcanvas;
    private bool isHurt;
   [SerializeField] public void ActivateHurtCanvas()
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
