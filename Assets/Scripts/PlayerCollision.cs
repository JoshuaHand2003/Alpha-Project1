using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerController movement;
    public GameObject explosionParticle;
    public bool isOnGround = false;
    public AudioSource source;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            source.Play();
            Instantiate(explosionParticle, transform);
            movement.enabled = false;
            FindObjectOfType<Manager>().EndGame();

          
        }
        else if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }
     
    }
}
