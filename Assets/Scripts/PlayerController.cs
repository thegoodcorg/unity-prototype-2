using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float moveSpeed = 25f;
    public float xRange = 15f;

    public GameObject projectilePrefab;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * horizontalInput * moveSpeed);

        if (Input.GetKeyDown(KeyCode.Space))
        {

            // Instantiate is called to make a copy of the projectile prefab.
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
            // Launch a new projectile from the player.
        }
    }
}
