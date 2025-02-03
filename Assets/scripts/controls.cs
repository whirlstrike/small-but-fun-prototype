using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controls : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rigidBody;
    private float move;
    private float weight;
    public float MoveSpeed = 10f;
    public float Jumphight = 7f;
    private bool IsGrounded()
    {
        return GetComponent<Rigidbody2D>().linearVelocity.y == 0f;
    }


    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
            weight = rigidBody.mass;
            move = Input.GetAxis("Horizontal");
            rigidBody.linearVelocity = new Vector2(move * MoveSpeed, rigidBody.linearVelocity.y);

        if (Input.GetButtonDown("Jump"))
        {
            if (!IsGrounded())
            {
                Console.WriteLine("jump unavalable");
                //if not grounded player wont jump
            }
            else 
            {
                rigidBody.linearVelocity = new Vector2(rigidBody.linearVelocity.x, Jumphight);
                Console.WriteLine("jump activated");
                //if is grounded player will jump
            }
        }
        if(Input.GetKeyDown("z"))
        {
            transform.localScale = new Vector3(2f,2f,1f);
            MoveSpeed = 5f;
            Jumphight = 3.5f;
    //on pressing z
    // player starts to grow till z is not being pressed
}
        if (Input.GetKeyDown("x"))
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
            MoveSpeed = 10f;
            Jumphight = 7f;
            //on pressing x
            // player starts to srink till x is not being pressed

        }
        if (Input.GetKeyDown("c"))
        {
            transform.localScale = new Vector3(0.5f, 0.5f, 1f);
            MoveSpeed = 20f;
            Jumphight = 14f;
            //on pressing c
            // player will return to its default scale
        }
    }

}
