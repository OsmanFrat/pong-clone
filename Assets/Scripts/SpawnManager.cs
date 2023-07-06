using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject ballPrefab;
    public float spawnRange = 2f;

    //Spawn the ball
    public void SpawnBall()
    {
        Instantiate(ballPrefab,GenerateRandomPos(), ballPrefab.transform.rotation);
    }

    //Random position
    public Vector2 GenerateRandomPos()
    {
        float randomPosY = Random.Range(-spawnRange, spawnRange);

        Vector2 randomPos = new Vector2(0, randomPosY);

        return randomPos;

    }
    
}
