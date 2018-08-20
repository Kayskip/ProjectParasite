using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public float attackSpeed = 1.0f;
    //private Transform playerPos;
    public string enemyClass;
    public int health;
    public int strength;
    public float stamina;
    public float regenRate;
    public GameObject bullet;
    public float minDist;
    public float maxStamina;
    public GameObject firepoint;
    public bool detected = false;
    public float detectPoint;
    public float maxDetecPoint;
    public int detectRange;
    public float detectRate;
    public float detectLimit;
    Vector3 randomPosition;
    private float timeCount = 0.0f;
    public float attackPeriod = 5.0f;
    private float timeCount2 = 0.0f;
    public float movementPeriod = 5.0f;

    Transform playerPos;

    public void rangedAttack()
    {
        Transform firepointTransform = firepoint.transform;
        Instantiate(bullet, firepointTransform.position, firepointTransform.rotation);
    }

    public void shoot()
    {
        float attackCD = attackPeriod / attackSpeed;
        timeCount += 0.1f;
        if (timeCount > attackCD)
        {
            rangedAttack();
            timeCount = 0.0f;
        }
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

    public void walkToPlayer()
    {
        Vector3 _dir = playerPos.position - transform.position;
        float angle = Mathf.Atan2(_dir.y, _dir.x) * Mathf.Rad2Deg;
        Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * speed);
        transform.position = Vector2.MoveTowards(transform.position, playerPos.position, speed * Time.deltaTime);
    }

    public void randomMove() {
        Vector3 _dir = randomPosition - transform.position;
        float angle = Mathf.Atan2(_dir.y, _dir.x) * Mathf.Rad2Deg;
        Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * speed);
        transform.position = Vector2.MoveTowards(transform.position, randomPosition, speed * Time.deltaTime);
    }

    public void passiveRegen()
    {

    }

    public void deadEnd()
    {

    }

    public void actionControl() {
        playerPos = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        float xRange = playerPos.position.x - transform.position.x;
        float yRange = playerPos.position.y - transform.position.y;
        if ((xRange > -detectRange / 2 && xRange < detectRange / 2) || (yRange > -detectRange / 2 && yRange < detectRange / 2))
        {
            if (detectPoint < maxDetecPoint)
            { 
                detectPoint+= detectRate;
            }
        }
        else
        {
            if (detectPoint > 0)
            {
                detectPoint-= detectRate / 2;
            }
        }
        if (detectPoint > detectLimit)
        {
            detected = true;
        }
        else {
            detected = false;
        }

        if (detected == true) {
            walkToPlayer();
            shoot();
        }
        else {
            randomMove();
        }
    }

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float movementCD = movementPeriod / speed;
        timeCount2 += 0.1f;
        if (timeCount > movementCD)
        {
            randomPosition = new Vector3(Random.Range(-3.0f, 3.0f), Random.Range(-3.0f, 3.0f), 0);
            timeCount2 = 0.0f;
        }
        actionControl();

        //Not working somehow
        //transform.position = Vector2.MoveTowards(transform.position, playerPos.position, speed*Time.deltaTime);
    }
}
