using UnityEngine;

public class EnemySpawnerSystem : MonoBehaviour
{
    [Header("Prefabs")]
    public GameObject enemyFastPrefab;
    public GameObject enemyStrongPrefab;

    [Header("Spawn Settings")]
    public float spawnInterval = 2f;    
    public float spawnRangeX = 4f;     

    private float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            SpawnRandomEnemy();
            timer = 0f;
        }
    }

    void SpawnRandomEnemy()
    {

        GameObject prefabToSpawn;
        int roll = Random.Range(0, 2);

        if (roll == 0)
            prefabToSpawn = enemyFastPrefab;
        else
            prefabToSpawn = enemyStrongPrefab;

        float randomX = Random.Range(-spawnRangeX, spawnRangeX);
        Vector3 spawnPosition = new Vector3(randomX, 6f, 0f);

        Instantiate(prefabToSpawn, spawnPosition, Quaternion.identity);
    }
}