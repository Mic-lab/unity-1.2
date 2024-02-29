using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToAngle : MonoBehaviour
{
    public float speed = 40;
    public float angle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = new Vector3(Mathf.Cos(angle) * speed * Time.deltaTime, 0, Mathf.Sin(angle) * speed * Time.deltaTime);
        transform.Translate(direction * Time.deltaTime * speed);
    }
}
