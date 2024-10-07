using UnityEngine;

public class Player : MonoBehaviour
{
    public float maxSpeed = 10;
    public float acceleration = 5;
    public float jumpSpeed = 10;
    Rigidbody2D rb;
    public bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.velocity += Vector2.up * jumpSpeed;
        }

        if (Mathf.Abs(rb.velocity.x) < maxSpeed)
        {
            float hor = Input.GetAxisRaw("Horizontal");
            rb.velocity += Vector2.right * hor * Time.deltaTime * acceleration;
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        isGrounded = true;
        if (other.gameObject.CompareTag("Enemy"))
        {
            GameManager.instance.Die();
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            GameManager.instance.Die();
        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        isGrounded = false;
    }
}