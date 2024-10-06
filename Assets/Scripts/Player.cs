using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5;
    public float jumpSpeed = 10;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity += Vector2.up * jumpSpeed;
        }

        float hor = Input.GetAxisRaw("Horizontal");
        rb.velocity += Vector2.right * hor * Time.deltaTime * moveSpeed;
    }
}