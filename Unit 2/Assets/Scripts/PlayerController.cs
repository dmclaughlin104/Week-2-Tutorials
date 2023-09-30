using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //variables
    public float horizontalInput;
    public float verticalInput;
    public float speed = 10.0f;
    private float playerXBoundary = 25.0f;
    private float playerZUpperBoundary = 10.0f;
    private float playerZLowerBoundary = -1.0f;

    public Transform projectileSpawnPoint;

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
            Instantiate(projectilePrefab, projectileSpawnPoint.position, projectilePrefab.transform.rotation);
        }//if

        //assigning horizontal/vertical inputs to correct axis input
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        //move character horizontal & vertical based on input
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);

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

        //if statement to control player Z-axis upper boundary
        if (transform.position.z > playerZUpperBoundary)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, playerZUpperBoundary);
        }//if

        //if statement to control player Z-axis lower boundary
        if (transform.position.z < playerZLowerBoundary)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, playerZLowerBoundary);
        }//if

    }
     
}
