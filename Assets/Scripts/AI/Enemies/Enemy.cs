using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public float attackSpeed = 1.0f;
    public string enemyClass;
    //public int health;
    //public int strength;
    //public float stamina;
    //public float regenRate;
    public GameObject bullet;
    //public float minDist;
    //public float maxStamina;
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

    Transform playerTrans;

    public void rangedAttack()
    {
        Instantiate(bullet, firepoint.transform.position, firepoint.transform.rotation);
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
        Vector3 _dir = playerTrans.position - transform.position;
        float distX = _dir.x;
        float distY = _dir.y;
        if (distX < 0) distX = -distX;
        if (distY < 0) distY = -distY; 
        if (distX > 1 && distY > 1) {
            transform.position = Vector2.MoveTowards(transform.position, playerTrans.position, speed * Time.deltaTime);
        }
    }

    public void randomMove() {
        Vector3 targetPosition = transform.position + randomPosition;
        transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
    }

    public void passiveRegen()
    {

    }

    public void deadEnd()
    {

    }

    public void actionControl() {
        playerTrans = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

        Vector3 _dir = playerTrans.position - transform.position;
        float angle = Mathf.Atan2(_dir.y, _dir.x);
        float rotationAngle = angle * Mathf.Rad2Deg - 90 + Random.Range(-30.0f, 30.0f);
        firepoint.transform.eulerAngles = new Vector3(0, 0, rotationAngle);
        Vector2 offset = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle)) * 1.5f;
        Vector2 _center = transform.position;
        firepoint.transform.position = _center + offset;

        float xRange = playerTrans.position.x - transform.position.x;
        float yRange = playerTrans.position.y - transform.position.y;
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
        transform.eulerAngles = new Vector3(0, 0, 0);
        float movementCD = movementPeriod / speed;
        timeCount2 += 0.1f;
        if (timeCount2 > movementCD)
        {
            randomPosition = new Vector3(Random.Range(-3.0f, 3.0f), Random.Range(-3.0f, 3.0f), 0);
            timeCount2 = 0.0f;
        }
        actionControl();
    }
}
