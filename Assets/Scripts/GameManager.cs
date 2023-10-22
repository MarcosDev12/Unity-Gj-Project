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
        END,
    }

    public GameState currentGameState = GameState.INIT;

    public GameObject mainMenu;
    public GameObject gameplayHud;
    public GameObject endGameHud;


    // Start is called before the first frame update
    void Start()
    {
        gameplayHud.SetActive(false);
        endGameHud.SetActive(false);
        mainMenu.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
