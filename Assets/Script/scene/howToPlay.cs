using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class howToPlay : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Xで画面遷移
        if(Input.GetKeyDown(KeyCode.X))
        {
            SceneNavigator.Instance.Change("sceneSelect");
        }
    }
}
