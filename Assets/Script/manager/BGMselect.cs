using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BGMselect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ChangeBGM();
    }
    void ChangeBGM()
    {
        if(SceneManager.GetActiveScene().name == "title")
        {
            AudioManager.instance.PlayBGM("title");
        }
        if (SceneManager.GetActiveScene().name == "main")
        {
            AudioManager.instance.PlayBGM("main");
        }
        if (SceneManager.GetActiveScene().name == "clear")
        {
            AudioManager.instance.PlayBGM("clear");
        }
    }
}
