using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    public float speed;
    private Transform playerPos;
    public int health;
    public int strength;
    public float stamina;
    public float regenRate;
    protected float minDist = 1.5f;
    protected float aggroDist = 5f;
    protected float maxStamina;

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
