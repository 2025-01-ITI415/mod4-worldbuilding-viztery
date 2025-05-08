using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CoffinSpawner : MonoBehaviour
{
    public GameObject coffinPrefab;
    public int numberToSpawn = 10;
    public Vector3 spawnAreaSize = new Vector3(10, 0, 10);

    void Start()
    {
        for (int i = 0; i < numberToSpawn; i++)
        {
            Vector3 randomPos = transform.position + new Vector3(
                Random.Range(-spawnAreaSize.x / 2, spawnAreaSize.x / 2),
                0,
                Random.Range(-spawnAreaSize.z / 2, spawnAreaSize.z / 2)
            );

            Instantiate(coffinPrefab, randomPos, Quaternion.identity);
        }
    }
}
