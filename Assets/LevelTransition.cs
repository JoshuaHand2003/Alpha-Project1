using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelTransition : MonoBehaviour
{
    public string nextLevelName = "Level 2";

    // Called when another collider enters the trigger collider
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))  //checks if the player tag is on the object colliding in the trigger area
        {
            // Load the next level
            SceneManager.LoadScene(1);
        }
    }
}


