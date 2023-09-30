using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //variables
    public GameObject[] animalPrefabs;
    private float spawnPositionZ = 30.0f;
    private float spawnRangeX = 20.0f;
    private float startDelay = 2.0f;
    private float spawnInterval = 1.5f;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }//start

    // Update is called once per frame
    void Update()
    {

    }//update

    //method to spawn a random animal in a random location along the X-axis (between a range)
    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPosition = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPositionZ);
        Instantiate(animalPrefabs[animalIndex], spawnPosition, animalPrefabs[animalIndex].transform.rotation);
    }//SpawnRandomAnimal

}
