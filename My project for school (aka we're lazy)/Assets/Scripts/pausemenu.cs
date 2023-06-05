using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pausemenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
   
    public GameObject pauseMenuUI;
    // Update is called once per frame
     void Start()
    {

        pauseMenuUI.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }

    }
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    void Pause(){
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
}
    public void LoadMenu()
    {
        Time.timeScale = 1f;
        Debug.Log("caricamento menu.. :D");
        SceneManager.LoadScene("MENU");
    }
    public void QuitGame()
    {
        Debug.Log("torna presto! :D");
        Application.Quit();
    }
}
