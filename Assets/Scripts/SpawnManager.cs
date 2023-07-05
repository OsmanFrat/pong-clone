using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject ballPrefab;
    public float spawnRange = 2f;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(ballPrefab,GenerateRandomPos(), ballPrefab.transform.rotation);
        }
        
    }

    public Vector2 GenerateRandomPos()
    {
        float randomPosY = Random.Range(-spawnRange, spawnRange);

        Vector2 randomPos = new Vector2(0, spawnRange);

        return randomPos;

    }
    
}
