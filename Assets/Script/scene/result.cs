﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class result : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Result();
    }
    void Result()
    {
        // 各キーで画面遷移させる
        if ((SceneManager.GetActiveScene().name == "clear") || (SceneManager.GetActiveScene().name == "gameover"))
        {
            if (Input.GetKeyDown(KeyCode.X))
            {
                SceneNavigator.Instance.Change("sceneSelect");
            }
            if (Input.GetKeyDown(KeyCode.Z))
            {
                SceneNavigator.Instance.Change("title");
            }

        }
    }
}
