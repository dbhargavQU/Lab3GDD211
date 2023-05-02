using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnInterval = 3.0f;
    public float spawnAreaSize = 10.0f;

    private float spawnTimer;

    private void Update()
    {
        spawnTimer += Time.deltaTime;
        if (spawnTimer >= spawnInterval)
        {
            SpawnEnemy();
            spawnTimer = 0.0f;
        }
    }

    private void SpawnEnemy()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(-spawnAreaSize, spawnAreaSize), 1.0f, Random.Range(-spawnAreaSize, spawnAreaSize));
        Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
    }
}
