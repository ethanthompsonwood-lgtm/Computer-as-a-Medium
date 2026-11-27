using UnityEngine;

public class SpawnButton : MonoBehaviour
{
    public SpawnEnemy enemySpawner;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            enemySpawner.isSpawning = false;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            enemySpawner.isSpawning = true;
        }
    }
}
