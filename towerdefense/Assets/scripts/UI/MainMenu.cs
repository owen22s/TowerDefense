using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void mainMenu()
    {
        Debug.Log("lol");
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1f;
    }
    public void Lvl1()
    {
        SceneManager.LoadScene("Level_01");
        Time.timeScale = 1f; 
    }
    public void Lvl2()
    {
        SceneManager.LoadScene("Level_02");
        Time.timeScale = 1f;
    }
    public void Lvl3()
    {
        SceneManager.LoadScene("Level_03");
        Time.timeScale = 1f;
    }
}