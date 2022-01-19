using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayGame : MonoBehaviour
{
  
  
  public void PlayGame_Script()
    {
        SceneManager.LoadScene(1);



    }

    public void QuitGame()
    {
        Application.Quit();
    }
    public void GoBackMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void goHistoire()
    {
        SceneManager.LoadScene(5);
    }
}
