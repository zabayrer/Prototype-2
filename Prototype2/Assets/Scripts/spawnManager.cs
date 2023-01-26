using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour

{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 11;
    private float spawnPosZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        //spawn an animal
        InvokeRepeating("spawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void spawnRandomAnimal()
    {
        //spawns an animal
            int animalIndex = Random.Range (0, animalPrefabs.Length);
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX,spawnRangeX), 0, spawnPosZ);
            Instantiate (animalPrefabs[animalIndex], spawnPos,animalPrefabs[animalIndex].transform.rotation);
    }
}

