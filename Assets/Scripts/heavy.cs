using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heavy : Enemy{

    // Use this for initialization
    void Start () {
        stamina = 100f;
        health = 100;
        speed = 10;
        attackSpeed = 3.0f;
        strength = 30;
        regenRate = 1.0f;
        maxStamina = 100f;
    }

    public override void passiveRegen()
    {
        stamina += regenRate;
        health += (int)regenRate;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
