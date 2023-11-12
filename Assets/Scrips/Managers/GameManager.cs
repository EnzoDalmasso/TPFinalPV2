using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    private int score;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            score = Mathf.Max(PlayerPrefs.GetInt("PUNTAJE"),0);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void OnEnable()
    {
        GameEvents.OnPuase += Pausar;
        GameEvents.OnResume += Reanudar;
    }
    private void OnDisable()
    {
        GameEvents.OnPuase -= Pausar;
        GameEvents.OnResume -= Reanudar;
    }

    private void Pausar()
    {
        Time.timeScale = 0;
        
    }

    private void Reanudar()
    {
        Time.timeScale = 1;
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {

            if (Time.timeScale != 0)
                
            {
                Debug.Log(Time.timeScale);
                GameEvents.TriggerPause();
                
            }
            else
            {
                Debug.Log(Time.timeScale);
                GameEvents.TriggerResume();
            }
        }
    }


    public void AddScore(int points)
    {
        score += points;
        if(score<0)score=0;
        PlayerPrefs.SetInt("PUNTAJE", score);
        
    }

    public void ResetScore()
    {
        score = 0;
    }

    public int GetScore()
    {
        return score;
    }
}