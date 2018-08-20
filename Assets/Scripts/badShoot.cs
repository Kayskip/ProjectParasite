using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class badShoot : MonoBehaviour
{
    float interval = 1;

    public Transform firepoint;
    public GameObject bullet;
    
    // Update is called once per frame
    void Update()
    {
        interval -= Time.deltaTime;
        if (interval < 0)
        {
            shoot();
            interval = 1;
        }
    }

    void shoot()
    {
        Instantiate(bullet, firepoint.position, firepoint.rotation);
    }
}
