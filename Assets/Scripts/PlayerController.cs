using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float horizontalInput;
    public Camera cam;
    public float speed = 10.0f;
    public float xRange = 10.0f;
    public int maxHealth = 10;
    public int health = 10;
    public int points = 0;

    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        points = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // Movement
        Vector3 velocity = new Vector3(Input.GetAxis("Horizontal")*Time.deltaTime*speed, 0, 
                                       Input.GetAxis("Vertical")*Time.deltaTime*speed);
        transform.Translate(velocity);

        // Movement restriction
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        // Shoot
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject projectile = Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "animal"){
            Destroy(other.gameObject);
            health -= 1;
        }

    }

}
