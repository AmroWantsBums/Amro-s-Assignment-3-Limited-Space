using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PoliceCollisionCheck : MonoBehaviour
{
    public GameObject DeathCanvas;
    public TextMeshProUGUI HeadingTxt;
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
            DeathCanvas.SetActive(true);
            HeadingTxt.text = "You've been caught";
            Debug.Log("youve been caught");
        }
    }
}
