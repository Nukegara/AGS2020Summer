﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class title : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneNavigator.Instance.Change("stageSelect");
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            SceneNavigator.Instance.Change("HowToPlay");
        }
    }
}