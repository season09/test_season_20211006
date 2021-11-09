using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D Rigidbody2D;
    public float Speed;
    public float jumpforce;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }


    void Movement()
    {
        float horizontalmove = Input.GetAxis("Horizontal");
        float facedircetion = Input.GetAxisRaw("Horizontal");

        if (horizontalmove != 0)
        {
            Rigidbody2D.velocity = new Vector2(horizontalmove * Speed, Rigidbody2D.velocity.y);
        }
        if (facedircetion != 0)
        {
            transform.localScale = new Vector3(facedircetion, 1, 1);
        }

        if (Input.GetButtonDown("Jump"))
        {
            Rigidbody2D.velocity = new Vector2(Rigidbody2D.velocity.x, jumpforce);
        }
    }
}
