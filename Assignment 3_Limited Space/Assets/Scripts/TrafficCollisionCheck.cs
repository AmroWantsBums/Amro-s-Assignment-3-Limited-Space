using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficCollisionCheck : MonoBehaviour
{
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
            Time.timeScale = 0;
            Debug.Log("you crashed the car");
        }
    }
}
