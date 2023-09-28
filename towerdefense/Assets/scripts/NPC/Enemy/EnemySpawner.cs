using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;

    [SerializeField] private float timeBetweenWaves = 15;
    [SerializeField] private int enemiesPerWave = 8;
    private int enemiesSpawned = 0;

    void Start()
    {
        StartCoroutine(SpawnWave());
    }

    void Update()
    {

    }

    IEnumerator SpawnWave()
    {
        while (enemiesSpawned < enemiesPerWave)
        {
            Instantiate(enemyPrefab, transform.position, Quaternion.identity);
            enemiesSpawned++;
            Debug.Log("Spawned enemy " + enemiesSpawned);
            yield return new WaitForSeconds(1f);
        }
        Debug.Log("Wave complete. Resetting enemiesSpawned.");
        yield return new WaitForSeconds(timeBetweenWaves);
        StartCoroutine(SpawnWave());
    }
}
