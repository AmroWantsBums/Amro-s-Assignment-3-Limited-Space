using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    public  Scene LevelScene; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        if (currentScene.name != "DeathScene")
        {
            LevelScene = SceneManager.GetActiveScene();
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "Car")
        {
            SceneManager.LoadScene("LevelSelect");
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(LevelScene.name);
        Time.timeScale = 1;
    }
}
