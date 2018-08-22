using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour {

    [Range(-1f,1.5f)]
    public float currentSpeed;
    Animator animator;

	void Start () {
        Rigidbody2D myRigibody = gameObject.AddComponent<Rigidbody2D>();
        myRigibody.isKinematic = true;
        animator = GetComponent<Animator>();
       //test
	}
	
	void Update () {
        transform.Translate(Vector3.left * currentSpeed * Time.deltaTime);
	}

    private void OnTriggerEnter2D(Collider2D collision) {
        Debug.Log("Triggered");
        animator.SetBool("isAttacking", true);

    }

    public void SetSpeed(float speed) {
        currentSpeed = speed;
    }
    public void StrikeCurrentTarget(float damage) {
        Debug.Log(name + "Damaged"+ damage);
    }
}
