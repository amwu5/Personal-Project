using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject platformPrefab;
    public GameObject powerupPrefab;
    public GameObject meteorPrefab;
    private Vector3 spawnPos = new Vector3(20, -1, 1);
    private float startDelay = 2;
    private float repeatRate = 3;
    private float spawnInterval = 10.0f;
    private float spawnLimitXLeft = -13.0f;
    private float spawnLimitXRight = 9.0f;
    private float spawnPosY = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPlatform", startDelay, repeatRate);
        InvokeRepeating("SpawnMeteor", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void SpawnPlatform ()
    {
        Instantiate(platformPrefab, spawnPos, platformPrefab.transform.rotation);
    }

    void SpawnMeteor ()
    {
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        Instantiate(meteorPrefab, spawnPos, platformPrefab.transform.rotation);
    }
}
