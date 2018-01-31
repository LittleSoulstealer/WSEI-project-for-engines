using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour {

    bool attacking=false;
    float attackTimer = 0f;
    float attackCd =0.3f;

    public Collider2D attackTrigger;
   

    private void Start ()
    {
        attackTrigger.enabled = false;
    }


    void Update() {

        if(Input.GetKeyDown ("j") && !attacking)
            {
            attacking = true;
            attackTimer = attackCd;
            attackTrigger.enabled = true;

        }
        if (attacking)
            if (attackTimer > 0)
            { attackTimer -= Time.deltaTime; }
        else
            {
                attacking = false;
                attackTrigger.enabled = false;
            }

    }

    void OnTriggerEnter(Collider enemy)
    {
        Debug.Log(enemy.gameObject);
    }

}
