using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class yonet : MonoBehaviour
{
    // Start is called before the first frame update
    int yerl = 0;
    int top = 3;
    int sceneIndex, levelPassed;


    void Start()
    {
        Debug.Log(PlayerPrefs.GetInt("LevelPassed"));
        sceneIndex = PlayerPrefs.GetInt("LevelPassed");
    }


    public void sayi()
    {
        yerl++;
        if (yerl == top)
        {
            PlayerPrefs.SetInt("LevelPassed", sceneIndex + 1);
            levelPassed = levelPassed + PlayerPrefs.GetInt("LevelPassed");
            SceneManager.LoadScene(levelPassed);
        }
    }


    void Update()
    {

    }
}
