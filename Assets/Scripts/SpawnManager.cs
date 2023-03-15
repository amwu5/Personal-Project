using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject platformPrefab;
    public GameObject powerupPrefab;
    private Vector3 spawnPos = new Vector3(20, -1, 1);
    private float startDelay = 2;
    private float repeatRate = 3;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPlatform", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnPlatform ()
    {
        Instantiate(platformPrefab, spawnPos, platformPrefab.transform.rotation);
    }
}
