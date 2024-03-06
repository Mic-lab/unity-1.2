using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayedHealthBar : MonoBehaviour
{
    public float startingWidth = 98f;
    public RectTransform healthBarRect;
    private float adjustSpeed = 0.95f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        int health = GameObject.Find("Player").GetComponent<PlayerController>().health;
        int maxHealth = GameObject.Find("Player").GetComponent<PlayerController>().maxHealth;
        float wantedWidth = (float)health / (float)maxHealth * startingWidth;
        float newWidth = (wantedWidth - healthBarRect.sizeDelta.x) * adjustSpeed * Time.deltaTime;
        healthBarRect.sizeDelta += new Vector2(newWidth, 0);

    }
}
