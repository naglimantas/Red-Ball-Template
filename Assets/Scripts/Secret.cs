using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class Secret : MonoBehaviour
{
    SpriteShapeRenderer renderer;
    bool visible;
    float a = 1f;
    private void Start()
    {
        renderer = GetComponent<SpriteShapeRenderer>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        renderer.color = new Color(1, 1, 1, 0f);
    }
    void Update()
    {
        if (visible)
        {
            a-
            renderer.color = new Color(1, 1, 1, 0f);
        }
    }
}
