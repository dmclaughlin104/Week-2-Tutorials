using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //variables
    public GameObject[] animalPrefabs;
    public float topBoundary = 35.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.S))
        {

            int animalIndex = Random.Range(0, animalPrefabs.Length);
            float spawnXAxis = Random.Range(-25, 25);

            Instantiate(animalPrefabs[animalIndex], new Vector3(spawnXAxis, 0, 35), animalPrefabs[animalIndex].transform.rotation);
        }
        
    }
}
