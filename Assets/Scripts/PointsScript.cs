using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class PointsScript : MonoBehaviour
{
    public TextMeshProUGUI text;
    public GameObject player;
    public int initialPoints;
    public int points;


    // Start is called before the first frame update
    void Start()
    {
        initialPoints = player.GetComponent<PlayerController>().points;
    }

    // Update is called once per frame
    void Update()
    {
       points = player.GetComponent<PlayerController>().points - initialPoints;
       text.text = "Points : " + points;

    }
}
