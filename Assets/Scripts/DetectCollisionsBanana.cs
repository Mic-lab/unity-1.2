using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsBanana : MonoBehaviour
{
    public GameObject particleManager;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "animal"){
            print(other.tag);
            Instantiate(particleManager, gameObject.transform.position, particleManager.transform.rotation);
            Destroy(other.gameObject);
        }

    }
}
