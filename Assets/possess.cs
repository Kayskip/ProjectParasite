using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class possess : MonoBehaviour {

    int preHealth;
    Sprite preSprite;



	void Start () {
        preSprite = gameObject.GetComponent<SpriteRenderer>().sprite;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Jump"))
        {
            Health health = gameObject.GetComponent<Health>();
            preHealth = health.getHealth();
            health.possess(true);
            shooting shoot = gameObject.GetComponent<shooting>();
            shoot.possess(true);
        }
	}
}
