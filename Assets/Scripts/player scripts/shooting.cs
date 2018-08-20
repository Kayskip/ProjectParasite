using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour {

    public Transform firepoint;
    public GameObject bullet;
    bool possessing;

    private void Start()
    {
        possessing = false;
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetButtonDown("Fire1") && possessing)
        {
            Instantiate(bullet, firepoint.position, firepoint.rotation);
        }
	}

    public void possess(bool change)
    {
        possessing = change;
    }
}
