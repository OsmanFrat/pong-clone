using UnityEngine;

public class Player2Goal : MonoBehaviour
{
    public GameManager gameManagerScript;
    public SpawnManager spawnManagerScript;

    private void OnCollisionEnter2D(Collision2D other) 
    {    
        if(other.gameObject.CompareTag("Ball"))
        {
            gameManagerScript.Player2AddScore();
            Destroy(other.gameObject);
            spawnManagerScript.SpawnBall();
        }
    }
}
