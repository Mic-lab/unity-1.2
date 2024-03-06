using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleManager : MonoBehaviour
{
    // public List<GameObject> particles;
    // public List<GameObject> alphaChanges;

    // public Material material;
    // public GameObject particleObject;
    // public GameObject alphaChange;
    private float timer = 0f;
    private float duration = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= duration)
        {
            Destroy(gameObject);
        }
        // if (Input.GetKeyDown(KeyCode.Z)){
            // GameObject particleInstance = Instantiate(particleObject, new Vector3(0, 0, 0), particleObject.transform.rotation);
            // GameObject alphaChangeInstance = Instantiate(alphaChange, alphaChange.transform.position, alphaChange.transform.rotation);
            // Material material = new Material(Shader.Find("Smoke"));
            
            // particleInstance.GetComponent<Renderer>().material = Instantiate(particleObject.GetComponent<Renderer>().material);
            // particles.Add(particleInstance);
            // alphaChanges.Add(alphaChangeInstance);
        }
        
    }

