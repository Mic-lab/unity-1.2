using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float horizontalInput;
    public Camera cam;
    public float speed = 10.0f;
    public float xRange = 10.0f;

    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
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

        // Rotate towards mouse
        //Vector3 mousePos = Input.mousePosition;
        // Vector3 mousePos = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, 0, Input.mousePosition.y));
        Vector3 mousePos = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, 0.0f, Input.mousePosition.y));
        float deltaX = mousePos.x - transform.position.x;
        float deltaY = mousePos.z - transform.position.z;
        float projectileAngle = Mathf.Atan2(deltaY, deltaX); /// Mathf.PI * 180;
        print(projectileAngle);
        // print(projectileAngle / Mathf.PI * 180);
        // mousePos = cam.ScreenToWorldPoint(Input.mousePosition.x);
        // Vector2 direction = mousePos

        // Rotate towards mouse

        // Shoot
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject projectile = Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
            projectile.GetComponent<MoveToAngle>().angle = projectileAngle;
            //Instantiate(projectilePrefab, transform.position, Quaternion.Euler(Vector3(0, 0, angle));
        }
    }
}
