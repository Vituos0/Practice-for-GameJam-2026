using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using System;

public class GameManager : MonoBehaviour
{
    public static Action<GameState> OnStateChanged;
    public static GameManager instance;
    public GameState currentGameState { get; private set; } = GameState.Playing;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetGameState(GameState newState)
    {
        if(newState == currentGameState) return;

        ExitState(currentGameState);
        currentGameState = newState;
        EnterState(newState);

        OnStateChanged?.Invoke(newState);
    }


    private void EnterState(GameState state)
    {
        switch(state)
        {
            case GameState.Playing:
                Time.timeScale = 1f;
                break;
            case GameState.NextLevel:
                Time.timeScale = 1f;
                break;

            case GameState.Pause:
                Time.timeScale = 0f;
                break;

            case GameState.Cutscene:
                Time.timeScale = 1f;
                break;
            case GameState.Dialogue:
                Time.timeScale = 1f;
                break;
        }    
    }

    private void ExitState(GameState state)
    {
        switch(state)
            {
            case GameState.Playing:
                break;
            case GameState.Pause:
                break;
            case GameState.Cutscene:
                break;
            case GameState.Dialogue:
                break;
        }
    }

}
