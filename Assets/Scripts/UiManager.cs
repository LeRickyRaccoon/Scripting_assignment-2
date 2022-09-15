using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UiManager : MonoBehaviour
{
    public int Score = 0;
    public int DeathCounter = 0;
    public float Timer = 0f;
    public TextMeshProUGUI TMPScore;
    public TextMeshProUGUI TMPDeathCounter;
    public TextMeshProUGUI TMPTimer;
    public bool playerReachedTheEnd = false;

    public void IncreaseScore()
    {
        Score++;
    }

    public void IncreaseDeathTimer()
    {
        DeathCounter++;
    }

    private void Update() 
    {
        Timer += Time.deltaTime;
        TMPScore.text = Score.ToString();
        TMPDeathCounter.text = DeathCounter.ToString();
        TMPTimer.text = Timer.ToString();
        if (SceneManager.GetActiveScene().buildIndex == 4)
        {
            Time.timeScale = 0f;                   
        }
        else
        {
            Time.timeScale = 1f;
        }
                
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Reset()
    {
        Score = 0;
        Timer = 0;
        DeathCounter = 0;
        TMPScore.text = Score.ToString();
        TMPDeathCounter.text = DeathCounter.ToString();
        TMPTimer.text = Timer.ToString();
    }
}
