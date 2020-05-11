using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goalNear : MonoBehaviour
{
    bool goalNearFlag;
    int SEcnt;

    private void Start()
    {
        goalNearFlag = false;
    }
    private void FixedUpdate()
    {
        if(goalNearFlag)
        {
            SEcnt++;
            if(SEcnt % 60 == 0)
            {
                AudioManager.instance.PlaySE("goalNear");
            }
        }
    }
    private void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.name == "player")
        {
            goalNearFlag = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        SEcnt = 0;
        goalNearFlag = false;
    }
}
