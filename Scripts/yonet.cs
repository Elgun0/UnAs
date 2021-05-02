using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class yonet : MonoBehaviour
{
    // Start is called before the first frame update
    int yerl = 0;
    int top = 15;




    void Start()
    {
    }


    public void sayi()
    {
        yerl++;
        if (yerl == top)
        {
            Invoke("loadMainMenu", 1f);




        }
    }

    void Update()
    {

    }
}
