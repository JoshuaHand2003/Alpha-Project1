using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using JetBrains.Annotations;

public class Manager : MonoBehaviour{

    public TextMeshProUGUI scoreText;
    public static int Score;
    public bool gamestarted;
    

    public GameObject GameOverUI,StartMenuUI;

    bool gameHasEnded = false;
    public void IncreaseScore()
    {
        Score++;
        scoreText.text = "Coins:" + Score;  //This increases the score based off the coins being picked up in game.
    }



    public void EndGame()
    {
        gameHasEnded = true;
        GameOverUI.SetActive(true); //this runs the endgame scenario providing options to restart or exit with the GameOverUI

    }
    public void ExitGame()
    {
        Application.Quit(); //this just quits the game whenu  chose to exit game


    }
    public void sendtoGit()
    {
        Application.OpenURL("https://github.com/JoshuaHand2003/Alpha-Project1");
    }
        


    public void startgame() 
    {
        StartMenuUI.SetActive(false); //starting the game based off of clicking start in the menu.
        gamestarted = true;

    }


    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); //This just restarts based on what scene is currently running works for (level 1 or 2)
    }
}
