using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{    
    public void StartButton()
    {
        SceneManager.LoadScene(1);
    }
    public void Retry()
    {
        SceneManager.LoadScene(1);
        GameManager.Instance.GetUiManager().Reset();
        GameManager.Instance.GetUiManager().playerReachedTheEnd = false;
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
