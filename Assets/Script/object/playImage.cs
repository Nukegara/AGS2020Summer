using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playImage : MonoBehaviour
{
    //操作説明画面の画像切り替え
    Image image;
    [SerializeField] Sprite sp0;
    [SerializeField] Sprite sp1;
    [SerializeField] Sprite sp2;
    int imageNum;
    [SerializeField]int maxImageNum;


    // Start is called before the first frame update
    void Start()
    {
        imageNum = 0;
        image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        // 画像番号の増減
        if(Input.GetKeyDown(KeyCode.LeftArrow) && (imageNum >= 0))
        {
            imageNum--;
        }
        if(Input.GetKeyDown(KeyCode.RightArrow) && (imageNum <= maxImageNum))
        {
            imageNum++;
        }
        // 画像切り替え
        if (imageNum == 0)
        {
            image.sprite = sp0;
        }
        if (imageNum == 1)
        {
            image.sprite = sp1;
        }
        if (imageNum == 2)
        {
            image.sprite = sp2;
        }
    }
}
