using UnityEngine;
using System.Collections;

public class Cheep : MonoBehaviour {

    float autoMove;
    public float speed=3.0f;
    float direction;
    public float moveRange;
    Vector2 firstPosition;
    bool dead;
    BoxCollider2D cheepBox;
    SpriteRenderer cheepSR;
    // Use this for initialization
    void Start()
    {
        speed = Random.Range(1, 3);
        moveRange = Random.Range(1, 5);
        autoMove = 0;
        cheepSR = GetComponent<SpriteRenderer>();
        cheepBox = GetComponent<BoxCollider2D>();
        direction = 1;
        firstPosition = transform.position;
        dead = false;
        cheepSR.flipX = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (!dead)
        {
            if (transform.position.x > firstPosition.x + moveRange)
            {
                transform.position = new Vector2(firstPosition.x + moveRange, transform.position.y);
                cheepSR.flipX = false;
                direction *= -1;
            }
            if (transform.position.x < firstPosition.x - moveRange)
            {
                transform.position = new Vector2(firstPosition.x - moveRange, transform.position.y);
                cheepSR.flipX = true;
                direction *= -1;
            }

            transform.Translate(Vector2.right * speed * Time.deltaTime * direction);
        }
        if(dead)
        {
            transform.Translate(Vector2.up * 5 * Time.deltaTime);
        }
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Fireball")
        {
            this.transform.Rotate(Vector3.forward, 180);
            Destroy(cheepBox);
            Destroy(this.gameObject, 1);
            dead = true;
            //Destroy(childOfGoomba);
        }
    }
}
