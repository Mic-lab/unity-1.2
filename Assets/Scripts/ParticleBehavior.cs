using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleBehavior : MonoBehaviour
{

    public Vector3 velocity;
    // public Material mat;

    // Start is called before the first frame update
    void Start()
    {
        // velocity = new Vector3(Random.Range(-10, 10), Random.Range(0, 10), Random.Range(-10, 10));
        velocity = new Vector3(Random.Range(-1, 1), Random.Range(0, 1), Random.Range(-1, 1));
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(velocity * Time.deltaTime);
    }
}