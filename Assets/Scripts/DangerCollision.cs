using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangerCollision : MonoBehaviour {
    private bool invincible = false;

    Collider2D _collider;
    void Start()
    {
        _collider = gameObject.GetComponent<Collider2D>();
    }
    void OnTriggerStay2D(Collider2D other)
   

    {
        

        if (!invincible)
        {
            if (other.tag == "Enemy")
            {
                
                
               PlayerStatus PlayerSts = transform.parent.GetComponent<PlayerStatus>();
                PlayerSts.health--;
                invincible = true;
                Debug.Log("IvF on");
                _collider.enabled = false;
                Invoke("InvincibleTime", 3);

            }
        }


    }

    void InvincibleTime()
    {
        Debug.Log("IvF off");
        invincible = false;
        _collider.enabled = true;
    }

}
