using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RealisticJump : MonoBehaviour {

    private float fallFasterConstant = 2.5f;
    private float lowJumpConstant = 2f;
    Rigidbody2D rb;
	// Use this for initialization
	void Awake () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if (rb.velocity.y < 0)
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (fallFasterConstant - 1) * Time.deltaTime;
        }
        else if (rb.velocity.y > 0 && !Input.GetButton("Jump"))
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpConstant - 1) * Time.deltaTime;
        }
    }
}
