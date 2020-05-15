using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UBblock : MonoBehaviour
{
    [SerializeField] GameObject block;
    int stageHight;     // ステージの縦幅
    int stageWidth;     // ステージの横幅
    // Start is called before the first frame update
    void Start()
    {
        stageHight = 10;
        stageWidth = 9;
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

    // Update is called once per frame
    void Update()
    {
    }
}
