using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour {

    [SerializeField] private int speed;
    private Rigidbody2D rb;
 
    private void Start()
    {
        rb =GetComponent<Rigidbody2D>();
    }

private void Movement()
{
       
        float move = Input.GetAxis("Horizontal");
        
        rb.velocity = new Vector2(speed*move,rb.velocity.y);
        if (Input.GetKeyDown("space"))
        {
            rb.AddForce(new Vector2(0.0f, 700.0f));
        }
}

   private void FixedUpdate()
    {
        Movement();
    }
}
