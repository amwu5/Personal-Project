using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject platformPrefab; 
    private Vector3 spawnPos = new Vector3 (25, -1, 0);

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(platformPrefab, spawnPos, platformPrefab.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
