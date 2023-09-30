﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    //variables
    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    //private float startDelay = 1.0f;
    private float spawnInterval = 0;
    private float spawnMin = 0.0f;
    private float spawnMax = 2.0f;
    private float minimumSeconds = 3.0f;

    private float secondsCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        //spawns first ball after specified delay
        //Invoke("SpawnRandonBall", startDelay);

        //continues spawning balls after a random interval each time
        //not sure if this is the correct approach
        //InvokeRepeating("InvokeSpawnRandomBall", startDelay, spawnInterval);
    }

    
    private void Update()
    {
        //counting seconds
        secondsCount += Time.deltaTime;

        if (secondsCount >= minimumSeconds)
        {
            //resetting counter
            secondsCount = 0;

            //generate random interval from range (to be added on top of 3 seconds)
            spawnInterval = Random.Range(spawnMin, spawnMax);
            Debug.Log(spawnInterval);
            Invoke("SpawnRandomBall", spawnInterval);
        }
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {   
        //general random ball from array
        int randomBallSelector = Random.Range(0, 3);

        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[randomBallSelector], spawnPos, ballPrefabs[0].transform.rotation);
    }

    /*
    //method to invoke the SpawnRandomBall method after a continually updating interval
    void InvokeSpawnRandomBall()
    {
        //generate random interval from range
        spawnInterval = Random.Range(spawnMin, spawnMax);
        Invoke("SpawnRandomBall", spawnInterval);

        Debug.Log(spawnInterval);
    }
    */

}
