using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour {

    private GameObject Player;

    private Vector3 offset;

    private void Start()
    {
        Player = GameObject.Find("Player 1");
        offset = transform.position - Player.transform.position;
    }

    // Update is called once per frame
    void LateUpdate () {
        transform.position = Player.transform.position + offset;
             
	}
}
