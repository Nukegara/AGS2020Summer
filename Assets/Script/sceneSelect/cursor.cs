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
    Vector3 cursorPos;
    int stageNum;
    [SerializeField] GameObject tutorial;
    [SerializeField] GameObject stage1;
    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
        animCnt = 0;
        size = new Vector3(2.0f, 1.5f, 1.0f);
        defaultSize = new Vector3(2.0f, 1.5f, 1.0f);
        stageNum = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        cursorSize();
        cursorPosition();
    }
    void cursorSize()
    {
        // カーソルの大きさ変更
        int cnt = 10;
        animCnt++;
        if (animCnt / cnt % 4 == 0)
        {
            image.transform.localScale = new Vector3(size.x * 0.95f, size.y * 0.95f, size.z * 0.95f);
        }
        if (animCnt / cnt % 4 == 1)
        {
            image.transform.localScale = defaultSize;
        }
        if (animCnt / cnt % 4 == 2)
        {
            image.transform.localScale = new Vector3(size.x * 1.05f, size.y * 1.05f, size.z * 1.05f);
        }
        if (animCnt / cnt % 4 == 3)
        {
            image.transform.localScale = defaultSize;
        }
    }
    void cursorPosition()
    {
        // カーソルの位置
        // ステージ番号変更
        stageNum = stageChoose.stageNum;
        // カーソル位置変更
        image.rectTransform.position = cursorPos;
        if (stageNum == 1)
        {
            cursorPos = tutorial.transform.position;
        }
        if (stageNum == 2)
        {
            cursorPos = stage1.transform.position;
        }
    }
}
