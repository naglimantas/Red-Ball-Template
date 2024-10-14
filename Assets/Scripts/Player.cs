using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float maxSpeed = 10;
    Rigidbody2D rb;
    public float accelaration = 10;
    public float jumpSpeed = 10;
    public bool isGrounded;
    public GameObject playerPiece;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.velocity += Vector2.up * jumpSpeed;
        }
        if(Mathf.Abs(rb.velocity.x) < maxSpeed)
        {
            float hor = Input.GetAxisRaw("Horizontal");
            rb.velocity += Vector2.right * hor * Time.deltaTime * accelaration;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        isGrounded = true;
        if (other.gameObject.CompareTag("Enemy"))
        {
            for(int i = 0; i <10; i++)
            {
                var pos = transform.position + Random.insideUnitSphere;
                Instantiate(playerPiece,transform.position,transform.rotation);
            }
            gameObject.SetActive(false);
            GameManager.instance.Die();
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        isGrounded = false;
    }
}
