using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void OnPlayButton()
    {
        SceneManager.LoadScene(1);
    }
    public void OnBackButton()
    {
        SceneManager.LoadScene(0);
    }

    public void OnHowToButton()
    {
        SceneManager.LoadScene(2);
    }

    public void OnEscape()
    {
       
        SceneManager.LoadScene(0);
        
    }
    public void OnQuitButton()
    {
        Application.Quit();
    }
}
