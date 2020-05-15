using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBlock : MonoBehaviour
{
    GameObject block;
    public static bool airFlag;
    int airCnt;
    // Start is called before the first frame update
    void Start()
    {
        block = this.GetComponent<GameObject>();
        airFlag = false;
        airCnt = 0;
    }

    void FixedUpdate()
    {
        airCnt+=1;
        if(airCnt >= 60)
        {
           airFlag = false;
        }
        else if(airCnt <= 60)
        {
            airFlag = true;
        }
    }
    // Update is called once per frame
    private void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.tag == "underAttack")
        {
            if (characterController.underAttackFlag)
            {
                airFlag = true;
                airCnt = 0;
            }
        }
        if (collision.gameObject.tag == "sideAttack")
        {
            if (characterController.sideAttackFlag)
            {
                airFlag = true;
                airCnt = 0;
            }
        }
    }
}
