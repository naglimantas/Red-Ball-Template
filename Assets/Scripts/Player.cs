using UnityEngine;

public class Player : MonoBehaviour
{
    public float maxSpeed = 10;
    public float acceleration = 5;
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

        if (rb.velocity.magnitude < maxSpeed)
        {
            float hor = Input.GetAxisRaw("Horizontal");
            rb.velocity += Vector2.right * hor * Time.deltaTime * acceleration;
        }
    }
}