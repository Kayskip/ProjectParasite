using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour {

    public Transform firepoint;
    public GameObject bullet;

	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(bullet, firepoint.position, firepoint.rotation);
        }
	}
}
