using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    //variables
    private float topBundary = 35.0f;
    private float lowerBoundary = -15.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //destroy gameObjects if they leave gameplay area
        if (transform.position.z > topBundary)
        {
            Destroy(gameObject);
        }//if
        else if (transform.position.z < lowerBoundary)
            {
                Destroy(gameObject);
            }//else if

    }
}
