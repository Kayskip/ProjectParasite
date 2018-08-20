using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npcHealth : MonoBehaviour {
    public int maxHealth;
    private int currentHealth;

    // Use this for initialization
    void Start () {
		currentHealth = maxHealth;
	}

    // Update is called once per frame
    void Update()
    {
        if (currentHealth == 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            currentHealth--;
        }
    }
    public int getHealth()
    {
        return currentHealth;
    }
}
