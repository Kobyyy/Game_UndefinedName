using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    
    public void PlayGame()
    {
        SceneManager.LoadScene("SampleScene");
        
    }
    public void CloseGame()
    {
        Application.Quit();
    }
    // Update is called once per frame
   
}
