using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;

[DefaultExecutionOrder(-10000)]

public class CameraFollow : MonoBehaviour
{
    public float speed;
    public Transform target;

    void LateUpdate()
    {
        var targetPos = target.position;
        targetPos.z = -10;
        transform.position = Vector3.Lerp(transform.position,targetPos, 0.03f);
    }
}
