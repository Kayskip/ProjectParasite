using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour {
    Vector3 playerpos;
    GameObject player;
    // Use this for initialization
    void Start () {
         player = GameObject.Find("Player 1");
    }
	
	// Update is called once per frame
	void Update () {
        Transform playerTransform = player.gameObject.GetComponent<Transform>();
        playerpos = playerTransform.position;
        Quaternion rotation = Quaternion.LookRotation(transform.position - playerpos, Vector3.forward);
        rotation.x = 0;
        rotation.y = 0;
        transform.rotation = rotation;

    }
}
