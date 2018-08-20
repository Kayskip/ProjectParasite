using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : Enemy{

	// Use this for initialization
	void Start () {
        stamina = 100f;
        health = 50;
        speed = 20;
        strength = 10;
        regenRate = .5f;
        maxStamina = 100f;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
