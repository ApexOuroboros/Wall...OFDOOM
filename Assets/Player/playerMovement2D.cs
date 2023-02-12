using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement2D : MonoBehaviour
{

    Rigidbody2D rb;

    public float speed;
    public float jSpeed;
    private Vector2 mVel;

    bool isJump;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float move = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(speed * move, rb.velocity.y);

        Jump();
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isJump)
        {
            isJump = true;

            rb.AddForce(new Vector2(rb.velocity.x, jSpeed));
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isJump = false;

            rb.velocity = Vector2.zero;
        }
    }

}
