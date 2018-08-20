using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scout : Enemy {

	// Use this for initialization
	void Start () {
        stamina = 50f;
        health = 50;
        speed = 10;
        attackSpeed = 1.0f;
        strength = 100;
        regenRate = .5f;
        maxStamina = 50f;
        accuracy = 0.6f;
        ammo = 20;
    }

    public override void passiveRegen()
    {
        stamina += regenRate;
        health += (int) regenRate;
    }
    // Update is called once per frame
    void Update () {
		
	}
}
