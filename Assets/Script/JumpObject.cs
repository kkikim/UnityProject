using UnityEngine;
using System.Collections;

public class JumpObject : MonoBehaviour {
    Animator jumpAni;
    BoxCollider2D collideBox;
    bool firstIn;
    bool secondIn;

    float jumpPower;

    GameObject player;
	// Use this for initialization
        ////점프 1 상태
        //collideBox.offset = new Vector2(0.0f,0.7f);
        //collideBox.size = new Vector2(1.0f,1.5f);
        ////점프 2 상태
        //collideBox.offset = new Vector2(0.0f, 0.5f);
        //collideBox.size = new Vector2(1.0f, 1.0f);
	void Start () 
    {
        player = GameObject.Find("Player"); 
        firstIn = false;
        secondIn = false;
        jumpAni = GetComponent<Animator>();
        collideBox = GetComponent<BoxCollider2D>();
        jumpPower = 1000.0f;
	}
	
	// Update is called once per frame
	void Update () 
    {
	    

	}
    void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.gameObject.tag== "Player")
        {
            if (!firstIn&&!secondIn)
            {   //점프 1 상태
                firstIn = true;
                jumpAni.Play("jump2");
                collideBox.offset = new Vector2(0.0f, 0.5f);
                collideBox.size = new Vector2(1.0f, 1.0f);
                Invoke("changeSecondIn", 0.2f);

                Invoke("jumpOnObject",2.0f);
            }
        }

    }
    void OnCollisionExit2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            if(firstIn && secondIn)
            {
                firstIn = false;
                jumpAni.Play("jump1");
                collideBox.offset = new Vector2(0.0f, 0.7f);
                collideBox.size = new Vector2(1.0f, 1.5f);

                firstIn = false;
                secondIn = false;
                CancelInvoke("jumpOnObject");

            }
        }
    }
    void changeSecondIn()
    {
        secondIn = true;
    }
    void jumpOnObject()
    {
        player.GetComponent<Rigidbody2D>().AddForce(new Vector2(0.0f, jumpPower));

        jumpAni.Play("jump1");
        collideBox.offset = new Vector2(0.0f, 0.7f);
        collideBox.size = new Vector2(1.0f, 1.5f);

        firstIn = false;
        secondIn = false;
    }
}
