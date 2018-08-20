using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    public float speed;
    public float attackSpeed;
    private Transform playerPos;
    public string enemyClass;
    public int health;
    public int strength;
    public float stamina;
    public float regenRate;
    public GameObject bullet;
    public float minDist;
    public float aggroDist;
    public float maxStamina;


    public void passiveRegen() {
    }

    // Use this for initialization
    void Start () {
        //playerPos = GameObject.FindGameObjectWithTag("Player 1").GetComponent<Transform>();
        //Debug.Log(playerPos);
	}

	// Update is called once per frame
	void Update () {
        //Not working somehow
        //transform.position = Vector2.MoveTowards(transform.position, playerPos.position, speed*Time.deltaTime);
	}
}
