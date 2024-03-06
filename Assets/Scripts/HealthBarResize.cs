using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarResize : MonoBehaviour
{
    public float startingWidth = 98f;
    public RectTransform healthBarRect;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        int health = GameObject.Find("Player").GetComponent<PlayerController>().health;
        int maxHealth = GameObject.Find("Player").GetComponent<PlayerController>().maxHealth;
        float newWidth = (float)health / (float)maxHealth * startingWidth;
        print(health + " / " + maxHealth + " * " + startingWidth + " = " + newWidth);
        healthBarRect.sizeDelta = new Vector2(newWidth, healthBarRect.sizeDelta.y);

    }
}
