using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controls : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rigidBody;
   public float MoveSpeed = 1.0f;
    public float Jumphight = 1.0f;


    void Start()
    {
        rigidBody.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rigidBody.velocity = new Vector2(rigidBody.velocity.x, Jumphight);
        }
    }
    private void FixedUpdate()
    {
        if (Input.GetButtonDown("Horizontal"))
        {
            rigidBody.velocity = new Vector2(1 * MoveSpeed, rigidBody.velocity.y);
        }
    }
}
