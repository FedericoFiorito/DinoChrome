using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float jumpForce;
    public float bounceForce;

    public Rigidbody2D theRB;

    private bool isGrounded;
    public Transform groundCheckpoint;
    public LayerMask whatIsGround;

    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheckpoint.position, .2f, whatIsGround);

        if (Input.GetButtonDown("Jump"))
        {
            if (isGrounded)
            {
                theRB.velocity = new Vector2(theRB.velocity.x, jumpForce);
            }
        }
    }
}
