using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brakefunction : MonoBehaviour
{
    public float limit;
    private bool playerweight()
    {
        return GetComponent<Rigidbody2D>().linearVelocity.y == 0f;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(playerweight())
        {
            
        }
    }
}
