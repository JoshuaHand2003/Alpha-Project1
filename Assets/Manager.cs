using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using JetBrains.Annotations;

public class Manager : MonoBehaviour{

    public bool gamestarted;
    

    public GameObject GameOverUI,StartMenuUI;

    bool gameHasEnded = false;

    public void EndGame()
    {
        gameHasEnded = true;
        GameOverUI.SetActive(true);

    }
    public void ExitGame()
    {
        Application.Quit();


    }

    public void startgame() 
    {
        StartMenuUI.SetActive(false);
        gamestarted = true;

    }


    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
