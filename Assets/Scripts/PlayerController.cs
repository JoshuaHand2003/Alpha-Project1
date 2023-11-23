using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;




public class PlayerController : MonoBehaviour
{
    public bool hasPowerup = false;
    public float speed = 5.0f;
    public float turnSpeed;
    public float horizontalInput;
    public float forwardInput;
    public ParticleSystem particles;


    // Reference to the GameManager script
    public Manager manager;

    // Start is called before the first frame update
    void Start()
    {
        // Get the GameManager script
        manager = GameObject.Find("Manager").GetComponent<Manager>();
    }

    // Update is called once per frame
    void Update()
        
    {   if (manager.gamestarted) 
        { 
        horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        transform.Rotate(Vector3.up * Time.deltaTime * horizontalInput * turnSpeed);

        // Check for Y level condition
        if (transform.position.y <= -10)
        {
            GameOver();
        }

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Powerup"))
        {
            hasPowerup = true;
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("Obstacle"))
        {
            GameOver();
        }
    }

    // Game over function
    void GameOver()
    {
        // Trigger game over actions (e.g., show game over text, restart the game)
        manager.EndGame();
    }
}

