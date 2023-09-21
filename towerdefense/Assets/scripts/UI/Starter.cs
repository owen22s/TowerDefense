using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Starter : MonoBehaviour
{
    // Start is called before the first frame update
 
   public void starter() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1) ;
    }
}
