using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    public float moveSpeed = 10;
    public float jumpSpeed = 10;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity += Vector2.up * jumpSpeed;
        }

        var hor = Input.GetAxisRaw("Horizontal");
        rb.velocity += Vector2.right * hor * Time.deltaTime * moveSpeed;
    }
}
