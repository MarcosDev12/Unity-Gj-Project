using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public enum GameState
    {
        INIT,
        PLAYING,
        PLAYING_MINIGAME,
        END,
    }

    //public delegate void GameStartedHandler();
    //public event GameStartedHandler GameStarted;

    public delegate void CurrentGameStateHandler(GameState state);
    public event CurrentGameStateHandler GameStateChanged;
    
    private GameState currentGameState = GameState.INIT;
    public GameState gameState
    {
        get
        {
            return currentGameState;
        }

        set
        {
            currentGameState = value;
            if (GameStateChanged != null)
            {
                GameStateChanged(currentGameState);
            }
        }
    }


    public GameObject mainMenu;
    public GameObject gameplayHud;
    public GameObject endGameHud;
    public GameObject ingameEvents;


    // Start is called before the first frame update
    void Start()
    {
        gameState = GameState.INIT;
        gameplayHud.SetActive(false);
        endGameHud.SetActive(false);
        ingameEvents.SetActive(false);
        mainMenu.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartGameButtonPressed()
    {
        Debug.Log("start pressionado");
        gameState = GameState.PLAYING;
        mainMenu.SetActive(false);
        gameplayHud.SetActive(true);
        ingameEvents.SetActive(true);

    }
}
