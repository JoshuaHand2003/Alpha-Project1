using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{

    public Transform Player;
    public TextMeshProUGUI scoreText;

    void Update()
    {
        scoreText.text = Player.position.z.ToString("0"); // ToString makes it so there is no decimals displayed
    }
}
//this updates the TextUI for score relating to the player position (aka distance traveled)