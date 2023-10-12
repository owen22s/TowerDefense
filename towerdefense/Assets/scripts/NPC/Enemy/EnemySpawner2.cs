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
    public GameObject WinScreen;
    [Header("Events")]
    public static UnityEvent onEnemyDestroy = new UnityEvent();
    private float timeSinceLastSpawn;
    public int currentWave = 1;
    private int enemiesAlive;
    private int enemiesLeftToSpawn = 8;
    public bool IsSpawning = false;
    public GameObject Boss;
    public bool BossSpawned;
    private void Awake()
    {
        onEnemyDestroy.AddListener(EnemyDestroyed);
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
        if (timeSinceLastSpawn > (1.3f / EnemiesPerSecond) && enemiesLeftToSpawn > 0)
        {
            enemiesLeftToSpawn--;
            enemiesAlive++;
            spawnEnemy();
            timeSinceLastSpawn = 0f;
            if (currentWave == 10 && BossSpawned == false) 
            {
                IsSpawning = false;
                GameObject boss = Instantiate(Boss);
                BossSpawned = true;
                EndWave();
                boss.GetComponent<EnemyHP>().OnDestroy.AddListener(BossDestroyed);
            }
        }
        if (enemiesAlive == 0 && enemiesLeftToSpawn == 0)
        {
            EndWave();
        }
    }

    private void spawnEnemy()
    {
        int randomIndex = Random.Range(0, EnemyPrefabs.Length);
        GameObject prefabToSpawn = EnemyPrefabs[randomIndex];
        GameObject instantiatedPrefab = Instantiate(prefabToSpawn, transform.position, Quaternion.identity);
        waypointfollower waypointFollower = instantiatedPrefab.GetComponent<waypointfollower>();
    }
    public void EnemyDestroyed()
    {
        enemiesAlive--;
    }
    public int EnemiesPerWave()
    {
        return Mathf.RoundToInt(BaseEnemies * Mathf.Pow(currentWave, difficultyScalingFactor));
    }
    public void BossDestroyed()
    {
        Debug.Log("DES");
        WinScreen.SetActive(true);
        Time.timeScale = 0f;
    }
    private void EndWave()
    {
        IsSpawning = false;
        timeSinceLastSpawn = 0f;
        currentWave++;
        waveStarter.ShowStartWave();
    }
}
