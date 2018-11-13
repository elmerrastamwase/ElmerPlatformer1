using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walk : MonoBehaviour
{

    public float moveSpeed = 6;
    public float jumpSpeed = 12;
    public jumpCheck check;

    private Rigidbody2D rbody;

    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        rbody.velocity = new Vector2(
            Input.GetAxisRaw("Horizontal") * moveSpeed, 
            rbody.velocity.y);

        if (Input.GetButtonDown("Jump"))
        {
            if (check.isgrounded == true)
            {
                rbody.velocity = new Vector2(rbody.velocity.x, jumpSpeed);
            }
        }

    }
}
