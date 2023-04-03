using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float leftLimit = -22.0f;
    private float bottomLimit = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < leftLimit)
        {
            Destroy(gameObject);
        }

        else if (transform.position.y < -bottomLimit)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }

}
