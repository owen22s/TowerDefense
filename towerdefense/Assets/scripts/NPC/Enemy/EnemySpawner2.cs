using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class EnemySpawner2 : MonoBehaviour
{
    [Header("Attributes")]
    [SerializeField] private GameObject[] EnemyPrefabs;
    [SerializeField] private int BaseEnemies = 8;
    [SerializeField] private float EnemiesPerSecond = 0.5f;
    [SerializeField] private float timeBetweenWaves = 2f;
    [SerializeField] private float difficultyScalingFactor = 0.50f;
    public WaveStarter waveStarter;
    [Header("Events")]
    public static UnityEvent onEnemyDestroy = new UnityEvent();
    private float timeSinceLastSpawn;
    public int currentWave = 1;
    private int enemiesAlive; 
    private int enemiesLeftToSpawn = 8;
    public bool IsSpawning = false;
    private float speed = 2.3f;


    private void Awake()
    {
        onEnemyDestroy.AddListener(EnemyDestoryed);
    }

    public IEnumerator StartWave()
    {
        yield return new WaitForSeconds(timeBetweenWaves);
        IsSpawning = true;
        enemiesLeftToSpawn = EnemiesPerWave();
    }
    public void Update()
    {
        if (!IsSpawning) { return; }
       
        
        timeSinceLastSpawn += Time.deltaTime;
        if(timeSinceLastSpawn > (1.3f / EnemiesPerSecond) && enemiesLeftToSpawn > 0)
        {
            enemiesLeftToSpawn--;
            enemiesAlive++;
            spawnEnemy();
            timeSinceLastSpawn= 0f;
        }
        if (enemiesAlive == 0 && enemiesLeftToSpawn == 0) 
        {
            EndWave();
        }
    }
    
    private void spawnEnemy()
    {
        GameObject prefabToSpawn = EnemyPrefabs[0];
        GameObject instantiatedPrefab = Instantiate(prefabToSpawn, transform.position, Quaternion.identity);
        waypointfollower waypointFollower = instantiatedPrefab.GetComponent<waypointfollower>();
        waypointFollower.speed = speed;

    }
    public void EnemyDestoryed() {
    enemiesAlive--;
    }
    public int EnemiesPerWave()
    {
        return Mathf.RoundToInt(BaseEnemies * Mathf.Pow(currentWave, difficultyScalingFactor));
    }
    private void EndWave() 
    { 
        IsSpawning= false;
        timeSinceLastSpawn= 0f;
        currentWave++;
        speed += 0.2f;
        waveStarter.ShowStartWave();
    }
}
