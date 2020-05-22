using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stageChoose : MonoBehaviour
{
    public static int stageNum;
    int stageNumMin;
    int stageNumMax;
    // Start is called before the first frame update
    void Start()
    {
        stageNum = 1;
        stageNumMin = 1;
        stageNumMax = 2;
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        stageSelect();
    }
    void stageSelect()
    {
        // ステージ識別番号取得用の関数
        if (Input.GetKeyDown(KeyCode.LeftArrow) && stageNum > stageNumMin)
        {
            stageNum--;
            AudioManager.instance.PlaySE("select");
        }
        if(Input.GetKeyDown(KeyCode.RightArrow) && stageNum < stageNumMax)
        {
            stageNum++;
            AudioManager.instance.PlaySE("select");
        }
        // スペースを押して番号にあったステージに遷移させる
        if(Input.GetKeyDown(KeyCode.Space))
        {
            AudioManager.instance.PlaySE("決定");
            if (stageNum == 1)
            {
                SceneNavigator.Instance.Change("stage1");
            }
            if (stageNum == 2)
            {
                SceneNavigator.Instance.Change("stage2");
            }
        }
        // Xで操作説明画面
        if (Input.GetKeyDown(KeyCode.X))
        {
            SceneNavigator.Instance.Change("HowToPlay");
        }
    }
}
