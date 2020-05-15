using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bblock : MonoBehaviour
{
    GameObject block;
    // Start is called before the first frame update
    void Start()
    {
        block = GetComponent<GameObject>();
    }

    // Update is called once per frame
    private void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.tag == "underAttack")
        {
            if (characterController.underAttackFlag)
            {
                Destroy(gameObject);
                AudioManager.instance.PlaySE("attack");
            }
        }
        if (collision.gameObject.tag == "sideAttack")
        {
            if (characterController.sideAttackFlag)
            {
                Destroy(gameObject);
                AudioManager.instance.PlaySE("attack");
            }
        }
    }
}
