using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float secondsCounter = 0;
    private float minSeconds = 1;

    // Update is called once per frame
    void Update()
    {
        //counting seconds since last dog was initiated
        secondsCounter += Time.deltaTime;

        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && (secondsCounter >= minSeconds))
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            secondsCounter = 0;//resetting seconds to 0
        }
    }
}
