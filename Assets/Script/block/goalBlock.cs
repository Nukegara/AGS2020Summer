using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goalBlock : MonoBehaviour
{
    public static bool goalFlag;
    // Start is called before the first frame update
    void Start()
    {
        goalFlag = false;
    }

    // Update is called once per frame
    private void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.tag == "underAttack")
        {
            if (characterController.underAttackFlag)
            {
                goalFlag = true;
            }
        }
        if (collision.gameObject.tag == "sideAttack")
        {
            if (characterController.sideAttackFlag)
            {
                goalFlag = true;
            }
        }

    }
}
