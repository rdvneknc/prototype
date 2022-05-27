using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] AnimalPrefabs;
    private float spawnRangeX = 20;
    private float spawnRangeZ = 38;
    private float startDelay = 3;
    private float spawnTiming = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnTiming);
    }


    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, AnimalPrefabs.Length);
        Vector3 spawnPosition = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0.0f, spawnRangeZ);
        Instantiate(AnimalPrefabs[animalIndex], spawnPosition, AnimalPrefabs[animalIndex].transform.rotation);
    }
}
