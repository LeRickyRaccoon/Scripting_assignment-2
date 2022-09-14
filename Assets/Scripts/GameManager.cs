using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;

    public static GameManager GetInstance()
    {
        if (instance == null)
        {
            GameObject go = new GameObject("GameManager");
            instance = go.AddComponent<GameManager>();
            DontDestroyOnLoad(go);
        }
        return instance;
    }
    private UiManager uiManager;
    public UiManager GetUiManager()
    {
        return uiManager;
    }

    private void Awake() 
    {
        if (instance != null)
        {
            Debug.LogErrorFormat("Trying to instantia a second instance of single class",GetType().Name);
        }
        else
        {
            instance = this;
        }        
    }
}
