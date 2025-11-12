using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
   public void Display()
    {
        SceneManager.LoadSceneAsync(1);
        
    }
    public void Display2()
    {
        SceneManager.LoadSceneAsync(2);
    }

    public void Display3()
    {
        SceneManager.LoadSceneAsync(3);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
