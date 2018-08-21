using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class possess : MonoBehaviour {

    int preHealth;
    Sprite preSprite;
    Health health;
    private SpriteRenderer spriteR;
    shooting shoot;



    void Start() {
        spriteR = gameObject.GetComponent<SpriteRenderer>();
        preSprite = spriteR.sprite;
        health = gameObject.GetComponent<Health>();
        preHealth = health.getHealth();
        shoot = gameObject.GetComponent<shooting>();
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetButtonDown("Jump"))
        {            
            GameObject target = FindClosest();
            if (target != null)
            {
                health.possess(true);
                shoot.possess(true);
                SpriteRenderer nSprite = target.GetComponent<SpriteRenderer>();
                spriteR.sprite = nSprite.sprite;
                //spriteR.
                health.setHealth(target.GetComponent<npcHealth>().getHealth());
                Transform Tpos = target.transform;
                Destroy(target);
                gameObject.transform.position = Tpos.position;

            }
        }
    }

    public void die()
    {
        shooting shoot = gameObject.GetComponent<shooting>();
        shoot.possess(false);
        Health health = gameObject.GetComponent<Health>();
        health.setHealth(preHealth);
        spriteR.sprite = preSprite;
    }

    private GameObject FindClosest()
    {
        GameObject[] targets;
        targets = GameObject.FindGameObjectsWithTag("Enemy");
        GameObject best = null;
        float distance = Mathf.Infinity;
        Vector2 pos = transform.position;
        foreach (GameObject target in targets)
        {
            Vector2 diff = (Vector2)target.transform.position - pos;
            float curDistace = diff.sqrMagnitude;
            if (curDistace < 10)
            {
                if (curDistace < distance)
                {
                    best = target;
                    distance = curDistace;
                }
            }
        }
        return best;
    }

    
}
