using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class possess : MonoBehaviour {

    int preHealth;
    Sprite preSprite;
    Health health;



    void Start() {
        preSprite = gameObject.GetComponent<SpriteRenderer>().sprite;
        health = gameObject.GetComponent<Health>();
        preHealth = health.getHealth();
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetButtonDown("Jump"))
        {            
            health.possess(true);
            shooting shoot = gameObject.GetComponent<shooting>();
            shoot.possess(true);
            GameObject target = FindClosest();
            Sprite nSprite = target.GetComponent<SpriteRenderer>().sprite;
            gameObject.GetComponent<SpriteRenderer>().sprite = nSprite;
            health.setHealth(target.GetComponent<npcHealth>().getHealth());
        }
    }

    public void die()
    {
        shooting shoot = gameObject.GetComponent<shooting>();
        shoot.possess(false);
        Health health = gameObject.GetComponent<Health>();
        health.setHealth(preHealth);
        gameObject.GetComponent<SpriteRenderer>().sprite = preSprite;
    }

    private GameObject FindClosest()
    {
        GameObject[] targets;
        targets = GameObject.FindGameObjectsWithTag("Enemy");
        GameObject best = null;
        float distance = Mathf.Infinity;
        Vector2 pos = transform.position;
        foreach(GameObject target in targets)
        {
            Vector2 diff = (Vector2)target.transform.position - pos;
            float curDistace = diff.sqrMagnitude;
            if(curDistace < distance)
            {
                best = target;
                distance = curDistace;
            }
        }
        return best;
    }

    
}
