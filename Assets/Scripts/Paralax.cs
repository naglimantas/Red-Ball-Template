using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paralax : MonoBehaviour
{
    public float scale;
    Transform cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main.transform;
    }
    void LateUpdate()
    {
        var pos = cam.transform.position / scale;
        pos.z = 0;
        transform.position = pos;
    }
}
