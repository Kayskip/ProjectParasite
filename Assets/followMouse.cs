using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followMouse : MonoBehaviour {
    private Camera cam;
	// Use this for initialization
	void Start () {
        cam = Camera.main;
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 mousepos = cam.ScreenToWorldPoint(Input.mousePosition);
        Vector3 perpendicular = Vector3.Cross(transform.position - mousepos, Vector3.forward);
        transform.rotation = Quaternion.LookRotation(transform.position - mousepos, Vector3.forward);
	}
}
