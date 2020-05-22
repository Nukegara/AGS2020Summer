using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UBblock : MonoBehaviour
{
    [SerializeField] GameObject block;
    int stageHight;     // ステージの縦幅
    int stageWidth;     // ステージの横幅
    string sceneName;   // シーンの名前
    // Start is called before the first frame update
    void Start()
    {
        // 現在のシーン名取得
        sceneName = SceneManager.GetActiveScene().name;
        // 外枠の大きさを決める
        if(sceneName == "stage1")
        {
            stageHight = 10;
            stageWidth = 9;
        }
        if(sceneName == "stage2")
        {
            stageHight = 20;
            stageWidth = 15;
        }
        // 外枠の生成
        for (int x = 0; x <= stageWidth; x++)
        {
            for (int y = 0; y <= stageHight; y++)
            {
                if ((x == 0) || (x == stageWidth) || (y == 0) || (y == stageHight))
                {
                    Instantiate(block, new Vector3(x * 3, y * 3, 0), Quaternion.Euler(0, 0, 180));
                }
            }
        }
    }
}
