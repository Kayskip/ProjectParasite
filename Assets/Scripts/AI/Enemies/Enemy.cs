using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    public float speed;
    public float attackSpeed;
    //private Transform playerPos;
    public string enemyClass;
    public int health;
    public int strength;
    public float stamina;
    public float regenRate;
    public GameObject bullet;
    public float minDist;
    public float aggroDist;
    public float maxStamina;
    public GameObject firepoint;

    private float timeCount;
    public float attackPeriod;

    public void rangedAttack()
    {
        Transform firepointTransform = firepoint.transform;
        Instantiate(bullet, firepointTransform.position, firepointTransform.rotation);
    }

    public void meleeAttack()
    {

    }

    public void grenade()
    {

    }

    public void rangedAim()
    {

    }

    public void grenadeAim()
    {

    }

    public void searchTheArea()
    {

    }

    public void passiveRegen() {
    }

    // Use this for initialization
    void Start () {
        timeCount = 0.0f;
        attackSpeed = 1.0f;
        attackPeriod = 5.0f;
	}

	// Update is called once per frame
	void Update () {
        float attackCD = attackPeriod / attackSpeed;
        timeCount+= 0.1f;
        if (timeCount > attackCD)
        {
            rangedAttack();
            timeCount = 0.0f;
        }
 
        //Not working somehow
        //transform.position = Vector2.MoveTowards(transform.position, playerPos.position, speed*Time.deltaTime);
    }
}
