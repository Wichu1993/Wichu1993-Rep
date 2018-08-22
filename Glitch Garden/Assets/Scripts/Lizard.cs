using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lizard : MonoBehaviour {

    public Attacker attacker;

	void Start () {
        attacker = GetComponent<Attacker>();
	}
	
	void Update () {
		
	}
}
