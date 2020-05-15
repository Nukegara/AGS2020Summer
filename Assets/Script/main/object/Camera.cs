using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    Transform cameraTrans;
    [SerializeField] Transform playerTrans;
    [SerializeField] Vector3 cameraVec;
    [SerializeField] Vector3 cameraRot;
    bool dirFlag;
    void Awake()
    {
        cameraTrans = transform;
        cameraTrans.rotation = Quaternion.Euler(cameraRot);
    }
    void LateUpdate()
    {
        cameraTrans.position = Vector3.Lerp(cameraTrans.position, playerTrans.position + cameraVec, 2.0f * Time.deltaTime * 2.0f);
    }
}
