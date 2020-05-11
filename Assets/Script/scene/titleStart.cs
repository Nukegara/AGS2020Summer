using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class titleStart : MonoBehaviour
{
    Image image;
    int cnt;
    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
        cnt = 0;
    }

    private void FixedUpdate()
    {
        cnt++;
        if (cnt / 30 % 2 == 0)
        {
            image.color = new Color(255, 255, 255, 255);
        }
        else
        {
            image.color = new Color(255, 255, 255, 0);
        }


    }

}
