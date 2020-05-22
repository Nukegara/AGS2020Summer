using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBlock : MonoBehaviour
{
    GameObject block;
    public static bool airFlag; // 高く跳ぶかどうかのフラグ
    int airCnt;                 // 高く跳ぶ時間
    // Start is called before the first frame update
    void Start()
    {
        block = this.GetComponent<GameObject>();
        airFlag = false;
        airCnt = 60;
    }

    void FixedUpdate()
    {
        airCnt+=1;
        if(airCnt >= 180)
        {
           airFlag = false;
        }
        else if(airCnt <= 180)
        {
            airFlag = true;
        }
    }
    // Update is called once per frame
    private void OnTriggerStay(Collider collision)
    {
        // ブロックを攻撃してCntを0にする
        if (collision.gameObject.tag == "underAttack")
        {
            if (characterController.underAttackFlag)
            {
                airCnt = 0;
            }
        }
        if (collision.gameObject.tag == "sideAttack")
        {
            if (characterController.sideAttackFlag)
            {
                airCnt = 0;
            }
        }
    }
}
