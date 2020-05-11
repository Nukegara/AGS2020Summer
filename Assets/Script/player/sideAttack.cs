using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sideAttack : MonoBehaviour
{
    public static bool sideFlag;
    public new static  string tag;
    new BoxCollider collider;

    bool difFlag;
    // Start is called before the first frame update
    void Start()
    {
        collider = GetComponent<BoxCollider>();
        sideFlag = false;
        tag = gameObject.tag;
    }
    void Update()
    {
        difFlag = characterController.dirFlag;

        if(tag == "sideAttack")
        {
            if (!difFlag)
            {
                collider.transform.localPosition = new Vector3(0, 0.5f, 0.3f);
            }
            else if (difFlag)
            {
                collider.transform.localPosition = new Vector3(0, 0.5f, 0.3f);
            }
        }
    }

    private void OnTriggerStay(Collider collider)
    {
        if (collider.gameObject.CompareTag("Bblock"))
        {
            if (tag == "sideAttack")
            {
                sideFlag = true;
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        sideFlag = false;
    }
}
