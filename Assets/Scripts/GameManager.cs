using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private UiManager uiManager;

    private void Start() 
    {
        uiManager = FindObjectOfType<UiManager>();
    }
    public UiManager GetUiManager()
    {
        return uiManager;
    }

    private void Awake() 
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else 
        {
            Destroy(gameObject);
        }
    }
}
