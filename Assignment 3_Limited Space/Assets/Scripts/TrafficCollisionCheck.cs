using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TrafficCollisionCheck : MonoBehaviour
{
    public GameObject DeathCanvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Car")
        {
            if (Time.timeScale != 0)
            {
                Time.timeScale = 0;
                DeathCanvas.SetActive(true);
                Debug.Log("you crashed the car");
            }
        }
    }
}
