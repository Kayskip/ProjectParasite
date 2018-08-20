using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyuse : MonoBehaviour {
    bool hasKey = false;

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Key")
        {
            hasKey = true;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Door" && hasKey)
        {
            hasKey = false;
            Destroy(collision.gameObject);
        }
    }
}
