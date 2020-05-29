using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBlock : MonoBehaviour
{
    // ジャンプブロックの処理
    Object block;
    bool airFlag;           // 高く跳ぶかどうかのフラグ
    static int airCnt;      // 高く跳ぶ時間
    int maxAirCnt;          // 高く跳べる時間
    int blockNum;           // ブロックの数
    ParticleSystem childObject;
    // Start is called before the first frame update
    void Start()
    {
        block = this.GetComponent<Object>();
        blockNum = GameObject.FindGameObjectsWithTag("jumpBlock").Length;
        maxAirCnt = 60 * blockNum;
        airCnt = maxAirCnt;
        childObject = transform.GetChild(0).gameObject.GetComponent<ParticleSystem>();
        childObject.startSpeed = 12.0f;
        Debug.Log(maxAirCnt);
    }

    void FixedUpdate()
    {
        airCnt+=1;
        if(airCnt >= maxAirCnt)
        {
            characterController.airFlag = false;
            childObject.startSpeed = 12.0f;
        }
        else if(airCnt <= maxAirCnt)
        {
            childObject.startSpeed = 36.0f;
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
                characterController.airFlag = true;
            }
        }
        if (collision.gameObject.tag == "sideAttack")
        {
            if (characterController.sideAttackFlag)
            {
                airCnt = 0;
                characterController.airFlag = true;
            }
        }
    }
}
