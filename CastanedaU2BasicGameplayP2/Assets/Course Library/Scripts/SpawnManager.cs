using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;

    private float spawnRangeZ = 14;
    private float spawnRangeX = 20;
    private float spawnPosZ= 20;
    private float spawnPosX = 20;

    private float startDelay = 2;
    private float spawnInterval = 5;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
        InvokeRepeating("SpawnRandomAnimalLeft", startDelay, spawnInterval);
        InvokeRepeating("SpawnRandomAnimalRight", startDelay, spawnInterval);

    }
    // Update is called once per frame
    void Update()
    {
       
    }
    void SpawnRandomAnimal()
    {
        Vector3 spawnpos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        int animalIndex = Random.Range(0, animalPrefabs.Length);

        Instantiate(animalPrefabs[animalIndex], spawnpos, animalPrefabs[animalIndex].transform.rotation);
    }
    void SpawnRandomAnimalLeft()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(-spawnPosX, 0, Random.Range(0, spawnRangeZ));
        Quaternion rotationLeft = Quaternion.Euler(0, 90, 0);
        Instantiate(animalPrefabs[animalIndex], spawnPos, rotationLeft);
        Debug.Log("Game Over!");
    }
    void SpawnRandomAnimalRight()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(spawnPosX, 0, Random.Range(0, spawnRangeZ));
        Quaternion rotationRight = Quaternion.Euler(0, 270, 0);
        Instantiate(animalPrefabs[animalIndex], spawnPos, rotationRight);
        Debug.Log("Game Over!");
    }

}
