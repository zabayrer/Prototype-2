﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;
    private float spawnInterval;
    private float startDelay = 4.5f;
    

    // Start is called before the first frame update
    void Start()
    {
        SpawnRandomBall();
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        
        //picks a random range to time when the ball drops
        spawnInterval = Random.Range (3, 5);
        
        //choses a random ball and puts it somewhere
        int ballIndex = Random.Range (0, ballPrefabs.Length);
        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);
        
        Invoke("SpawnRandomBall", spawnInterval);
    }

}