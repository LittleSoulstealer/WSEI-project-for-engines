using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackTrigger : MonoBehaviour
{
    public int dmg = 20;

   void OnTriggerExit2D(Collider2D col)
    {
        Debug.Log("AttackTrigger Collision");
            col.SendMessageUpwards("Damaged", dmg);
        
    }


}
