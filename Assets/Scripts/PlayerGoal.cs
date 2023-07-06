using UnityEngine;

public class PlayerGoal : MonoBehaviour
{
    public GameManager gameManagerScript;
    public SpawnManager spawnManagerScript;
    private void Start() 
    {
       
    }
    private void OnCollisionEnter2D(Collision2D other) 
    {    
        if(other.gameObject.CompareTag("Ball"))    
        {
            gameManagerScript.PlayerAddScore();
            Destroy(other.gameObject);
            spawnManagerScript.SpawnBall();
        }
    }
}
