using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    public int health = 40;
    Rigidbody2D rb;
    [SerializeField] private int speed;
   
    Vector2 size;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
       

    }
    public void Damaged(int damage)
    {
        health = health - damage;
    }


    void Update()
    {
        Movement();
      
        if (health<=0)

        {
            Destroy(gameObject);
        }
    }

    void Movement() {

        rb.velocity = new Vector2(speed, rb.velocity.y);

        size = GetComponent<BoxCollider2D>().size;

        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right * Mathf.Sign(speed),size.x);
        Debug.Log(hit.collider);
   
        if (hit.collider != null)
        {
            if (hit.collider.tag == "Ground")
            {
                Debug.Log("Ray");
                speed *= -1;
                gameObject.transform.Rotate(0, 180, 0);

            }
        }
           
    }


}