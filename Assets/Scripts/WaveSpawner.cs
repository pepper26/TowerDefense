using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class WaveSpawner : MonoBehaviour
{
    public Transform enemyPrefabs;

    public Transform spawnPoint;

    public float timeBetweenWaves = 5f;
    private float coutdown = 2f;

    public Text waveCountdownText;

    private int waveIndex = 0;

    private void Update()
    {
        if (coutdown <= 0)
        {
            StartCoroutine(SpawnWave());
            coutdown = timeBetweenWaves;
        }
        coutdown -= Time.deltaTime;

        waveCountdownText.text=Mathf.Round(coutdown).ToString();
    }

    IEnumerator SpawnWave()
    {
        waveIndex++;
        for (int i = 0 ; i < waveIndex ; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(0.5f);

        }

    }

    public void SpawnEnemy()
    {
        Instantiate(enemyPrefabs, spawnPoint.position, spawnPoint.rotation);
    }

}
