using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour {

    public int health = 3;



	
	// Update is called once per frame
	void FixedUpdate () {
		
        if(health<=0)
        {
            Destroy(gameObject);
        }
	}
   
}
