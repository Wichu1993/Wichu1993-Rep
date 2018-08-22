using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fox : MonoBehaviour {



	void Start () {
		
	}
	
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collider) {
        Debug.Log("Fox collided with " + collider);
    }
}
