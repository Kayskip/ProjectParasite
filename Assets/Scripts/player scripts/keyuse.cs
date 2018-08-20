using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyuse : MonoBehaviour {
    int keys;

    // Use this for initialization
    void Start()
    {
        keys = 0;

    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Key")
        {
            keys++;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Door" && keys > 0)
        {
            keys --;
            Destroy(collision.gameObject);
        }
    }
}
