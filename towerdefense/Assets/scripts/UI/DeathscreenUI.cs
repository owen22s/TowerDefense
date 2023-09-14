using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathscreenUI : MonoBehaviour
{
    public GameObject gameOverUI;
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl))
        {
            gameOverUI.SetActive(true);
        }

    }
    public void gameoverscreen()
    {
        gameOverUI.SetActive(true);
    }
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }
    public void mainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1f;
    }
    public void Quit()
    {
        Application.Quit();
    }
}
