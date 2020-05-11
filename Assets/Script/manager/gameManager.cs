using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Escでゲームを終了させる
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
