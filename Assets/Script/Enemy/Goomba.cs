﻿using UnityEngine;
using System.Collections;

public class Goomba : MonoBehaviour {

    float               autoMove;
    float               speed;
    public float               direction;
    public float        moveRange;
    Vector2             firstPosition;
    Animator            goombaAnimator;
    public BoxCollider2D       goombaBox;
    public GameObject          childBox;
    public BoxCollider2D       childBoxcollider;
    public bool                dead;
	// Use this for initialization
	void Start () 
    {
        autoMove    = 0;
        speed       = 3;
        //direction   = 1;
        firstPosition = transform.position;
        goombaAnimator = GetComponent<Animator>();
        dead = false;
        goombaBox = GetComponent<BoxCollider2D>();
        childBox = transform.Find("GoombaBoxChecker").gameObject;
        childBoxcollider = childBox.GetComponent<BoxCollider2D>();
        //childBoxcollider = GetComponentInChildren<BoxCollider2D>();

	}
	
	// Update is called once per frame
	void Update () 
    {
        if (!dead)
        {
            if (transform.position.x > firstPosition.x + moveRange)
            {
                transform.position = new Vector2(firstPosition.x + moveRange,transform.position.y);
                direction *= -1;
            }
            if (transform.position.x < firstPosition.x - moveRange)
            {
                transform.position = new Vector2(firstPosition.x - moveRange, transform.position.y);
                direction *= -1;
            }

            transform.Translate(Vector2.right * speed * Time.deltaTime * direction);
        }
        if(dead)
        {
            Destroy(this.gameObject, 0.9f);
        }

        
	}
    void OnCollisionEnter2D(Collision2D coll)
    {
       if(coll.gameObject.name == "Player")
       {
           goombaAnimator.Play("GoombaDead");
           Destroy(goombaBox);
           Destroy(childBoxcollider);
           Destroy(this.gameObject, 1);
           dead = true;
           //Destroy(childOfGoomba);
       }
       if (coll.gameObject.tag=="Shell")
       {
           goombaAnimator.Play("GoombaDead");
           Destroy(goombaBox);
           Destroy(childBoxcollider);
           Destroy(this.gameObject, 1);
           dead = true;
           //Destroy(childOfGoomba);
       }
    }
 
}
