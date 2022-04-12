using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject projectilePrefab;
    
    public float horizontalInput;
    public float speed = 20.0f;
    public float movementRange = 20;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        //player movement limits on the screen
        if(transform.position.x < -movementRange)
        {
            transform.position = new Vector3(-movementRange, transform.position.y, transform.position.y);
        }

        if (transform.position.x > movementRange)
        {
            transform.position = new Vector3(movementRange, transform.position.y, transform.position.y);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, new Vector3(transform.position.x, 2, transform.position.z), projectilePrefab.transform.rotation);
        }

        

        
    }
}
