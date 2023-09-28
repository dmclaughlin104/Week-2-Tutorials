using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //variables
    public float horizontalInput;
    public float speed = 10.0f;
    public float playerXBoundary = 25.0f;

    //prefab
    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if statement to shoot projectile
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }


        //if statement to control left player boundary
        if (transform.position.x  < -playerXBoundary)
        {
            transform.position = new Vector3(-playerXBoundary, transform.position.y, transform.position.z);
        }//if

        //if statement to control right player boundary
        if (transform.position.x > playerXBoundary)
        {
            transform.position = new Vector3(playerXBoundary, transform.position.y, transform.position.z);
        }//if

        //assigning horizontal input to correct input
        horizontalInput = Input.GetAxis("Horizontal");

        //moves character left/right based on input
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
    }
}
