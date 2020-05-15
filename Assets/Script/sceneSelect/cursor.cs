using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cursor : MonoBehaviour
{
    Image image;
    int animCnt;
    Vector3 size;
    Vector3 defaultSize;
    // Start is called before the first frame update
    void Start()
    {
        image.GetComponent<Image>();
        animCnt = 0;
        size = new Vector3(2.0f, 1.5f, 1.0f);
        defaultSize = new Vector3(2.0f, 1.5f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        animCnt++;
        if (animCnt / 20 % 3 == 0)
        {
            image.rectTransform.localScale = new Vector3(0, 0, 0);
        }
        if (animCnt / 20 % 3 == 1)
        {
            Debug.Log("中");
        }
        if (animCnt / 20 % 3 == 2)
        {
            Debug.Log("大");
        }
    }
}
