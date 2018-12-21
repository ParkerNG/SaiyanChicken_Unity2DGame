using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementManager2 : MonoBehaviour {

    [Range(0.0001f, 2f)] public float speed;
    [Range(1f, 10f)] public float jumpVelocity;
    // Use this for initialization
    private bool facingRight;
    private Rigidbody2D myRigidbody;
    void Start()
    {
        facingRight = true;
        myRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        MovementHandler(horizontal);
        Flip(horizontal);
    }

    //Handle pressed keyboards
    private void MovementHandler(float horizontal)
    {
        //Pres Right arrow
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.root.position += Vector3.right * speed;
        }
        //Press left arrow
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.root.position += Vector3.left * speed;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            Jump();
        }
    }

    //Flip the player when facing different direction
    private void Flip(float horizontal)
    {
        if (horizontal > 0 && !facingRight || horizontal < 0 && facingRight)
        {
            facingRight = !facingRight;
            Vector3 changedScale = transform.localScale;//Get the localScale of the current rigid body
            changedScale.x *= -1;
            transform.localScale = changedScale;
        }
    }


    //Jump function
    private void Jump()
    {
        myRigidbody.velocity = Vector3.up * jumpVelocity;
    }

}
