using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

    public int maxHealth;
    private int currentHealth;
    private bool isHit;
	// Use this for initialization
	void Start () {
        isHit = false;
        currentHealth = maxHealth;
	}
	
	// Update is called once per frame
	void Update () {
        if (isHit)
        {
            currentHealth--;
        }
        if (currentHealth == 0)
        {
            Destroy(gameObject);
        }
	}
}
