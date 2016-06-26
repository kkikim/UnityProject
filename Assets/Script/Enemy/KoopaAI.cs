using UnityEngine;
using System.Collections;

public class KoopaAI : MonoBehaviour {

    int hp;
    bool isJump;
    float jumpPower;
    float moveDirection;
    float moveVelocity;
    public Vector2 directionVector;
    float TimeLeftOfFire = 3.0f;      //쿠파 퐈이어 시간변수..//6초마다 발사
    float nextTimeOfFire = 0.0f;

    float TimeLeftOfJump = 8.0f;
    float nextTimeOfJump = 0.0f;

    float TimeLeftOfMove = 1.0f;
    float nextTimeOfMove = 0.0f;

    float TimeLeftOfGS = 10.0f;
    float nextTimeOfGS = 0.0f;

    GameObject player;
    SpriteRenderer koopaSR;

    public GameObject koopaFire;
    public GameObject deadParticle;
    public GameObject Goomba;
    Rigidbody2D rigid2d;
    public GameObject Lastwall;
   
	// Use this for initialization
	void Start () 
    {
        isJump = false;
        hp = 3;
        rigid2d = GetComponent<Rigidbody2D>();
        koopaSR = GetComponent<SpriteRenderer>();
        jumpPower = 450.0f;
        moveDirection -= 1.0f;
        moveVelocity = 3.0f;
        player = GameObject.Find("Player");
        directionVector = new Vector2(-1, 0);
        Lastwall = GameObject.Find("LastWall");
	}
	
	// Update is called once per frame
	void Update () 
    {
	    if(hp<0)
        {
            Instantiate(deadParticle, this.transform.position, Quaternion.identity);
            Destroy(this.gameObject);
            Destroy(Lastwall);
            
        }

        if (Time.time > nextTimeOfJump)         //쿠파점프
        {
            nextTimeOfJump = Time.time + TimeLeftOfJump;
            isJump = true;
        }

        if (Time.time > nextTimeOfFire)         //쿠파 미사일 발사.
        {
            nextTimeOfFire = Time.time + TimeLeftOfFire;
            Instantiate(koopaFire, new Vector2(this.transform.position.x +directionVector.x*2, this.transform.position.y + 1), Quaternion.identity);
        }

        //if (Time.time > nextTimeOfGS)         //굼바 소환
        //{
        //    nextTimeOfGS = Time.time + TimeLeftOfGS;
        //    Instantiate(Goomba, new Vector2(this.transform.position.x + Random.Range(-5,6), -1.5f), Quaternion.identity);
        //}

        //쿠파 무브.
        if (Time.time > nextTimeOfMove)         
        {
            nextTimeOfMove = Time.time + TimeLeftOfMove;
            moveDirection = Random.Range(-1, 2);
        }

        if(player.transform.position.x>transform.position.x)
        {
            Vector3 scale = transform.localScale;
            scale.x = -Mathf.Abs(scale.x);
            transform.localScale = scale;
            directionVector = new Vector2(1, 0);
        }
        else if (player.transform.position.x < transform.position.x)
        {
            Vector3 scale = transform.localScale;
            scale.x = Mathf.Abs(scale.x);
            transform.localScale = scale;
            directionVector = new Vector2(-1, 0);
        }
        if (hp >= 50)
        {
            transform.Translate(Vector2.left * moveDirection * moveVelocity * Time.deltaTime);
        }
        else if (hp < 50)
        {
            transform.Translate(Vector2.left * moveDirection * moveVelocity*1.5f * Time.deltaTime);
        }
	}
    void FixedUpdate()
    {
        DoJump();
    }
    void DoJump()
    {
        if (!isJump)
            return;

        rigid2d.AddForce(new Vector2(0.0f,jumpPower));

        isJump = false;
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.gameObject.tag == "Fireball")
        {
            hp -= 1;
        }
    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        print("trigger");
    }
}
