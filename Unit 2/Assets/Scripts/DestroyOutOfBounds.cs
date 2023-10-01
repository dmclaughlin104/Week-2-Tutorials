using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    //variables
    private float topBundary = 35.0f;
    private float lowerBoundary = -15.0f;
    private float sideBound = 30;

    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

    }

    // Update is called once per frame
    void Update()
    {
        //destroy gameObjects if they leave gameplay area
        //& trigger "Game Over" message if an animal gets past
        if (transform.position.z > topBundary)
        {
            Destroy(gameObject);
        }//if
        else if (transform.position.z < lowerBoundary)
        {
            gameManager.AddLives(-1);
            Destroy(gameObject);
        }//else if
        else if (transform.position.x > sideBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.x < -sideBound)
        {
            Destroy(gameObject);
        }

    }
}
