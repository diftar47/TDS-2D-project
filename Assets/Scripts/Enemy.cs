using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private Vector3 spawnRange;
    [SerializeField] private Transform spawnPosition;

    [SerializeField] private float timeBtwSpawn = 1f;

    private void Start()
    {
        StartCoroutine(EnemySpawn());
    }

    private IEnumerator EnemySpawn()
    {
        for (int i = 0; i < 10;) 
        {
            yield return new WaitForSeconds(timeBtwSpawn);
            Vector2 position = spawnPosition.position + new Vector3(Random.Range(-spawnRange.x, spawnRange.x), 0);
            Instantiate(enemyPrefab, position, Quaternion.identity);
        }
    }
}
