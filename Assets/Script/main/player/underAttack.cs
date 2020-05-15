using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class underAttack : MonoBehaviour
{
    public static bool underFlag;
    public new static  string tag;
    new BoxCollider collider;

    bool difFlag;
    // Start is called before the first frame update
    void Start()
    {
        collider = GetComponent<BoxCollider>();
        underFlag = false;
        tag = gameObject.name;

    }
    void Update()
    {
        difFlag = characterController.dirFlag;

        if (tag == "underAttack")
        {
            collider.transform.localPosition = new Vector3(0, 0, 0);
        }
    }

    private void OnTriggerStay(Collider collider)
    {
        if (collider.gameObject.CompareTag("Bblock"))
        {
            if (tag == "underAttack")
            {
                underFlag = true;
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        underFlag = false;
    }
}
