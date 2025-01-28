using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controls : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rigidBody;
    private float move;
    private float weight;
    public float MoveSpeed = 1.0f;
    public float Jumphight = 1.0f;
    [SerializeField] private Transform groundchecker;
    [SerializeField] private LayerMask groundlayer;
    private bool isgrounded()
    {
        return Physics2D.OverlapCircle(groundchecker.position, 0.2f, groundlayer);

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
            rigidBody.velocity = new Vector2(move * MoveSpeed, rigidBody.velocity.y);

        if (Input.GetButtonDown("Jump"))
        {
            if (isgrounded())
            {
                rigidBody.velocity = new Vector2(rigidBody.velocity.x, Jumphight);
            }
        }
        if(Input.GetKeyDown("z"))
        {
            transform.localScale = new Vector3(2f,2f,1f);
            //on pressing z
            // player starts to grow till z is not being pressed
        }
        if (Input.GetKeyDown("x"))
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
            //on pressing x
            // player starts to srink till x is not being pressed
        }
        if (Input.GetKeyDown("c"))
        {
            transform.localScale = new Vector3(0.5f, 0.5f, 1f);
            //on pressing c
            // player will return to its default scale
        }
    }

}
