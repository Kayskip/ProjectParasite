using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour {

    public int maxHealth;
    private int currentHealth;
    //private bool isHit;

    public Slider healthSlider;
    public Image damageImage;
    public float flashSpeed = 5f;
    public Color flashColour = new Color(1f, 0f, 0f, 0.1f);

	// Use this for initialization
	void Start () {
        currentHealth = maxHealth;
        //isHit = false;
	}
	
	// Update is called once per frame
	void Update () {
        /*
        if (currentHealth == 0)
        {
            Destroy(gameObject);
        }
        if (isHit)
        {
            damageImage.color = flashColour;
        }
        else
        {
            damageImage.color = Color.Lerp(damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
        }
        isHit = false;
        */
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            currentHealth--;
            healthSlider.value = currentHealth;
            //isHit = true;
        }
        if (collision.gameObject.tag == "Healthpack" && currentHealth < maxHealth)
        {
            currentHealth++;
        }
    }
}
