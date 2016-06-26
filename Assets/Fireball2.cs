using UnityEngine;
using System.Collections;

public class Fireball2 : MonoBehaviour {
    float velocity;
    Vector2 moveDirection;
    PlayCtrlInWater Move;
    public GameObject fireParticle;
    // Use this for initialization
    void Start()
    {
        velocity = 10.0f;
        Move = GameObject.Find("Player").GetComponent<PlayCtrlInWater>();
        moveDirection = Move.currentDirection;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(moveDirection * Time.deltaTime * velocity);
        Destroy(this.gameObject, 3);
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        Instantiate(fireParticle, this.transform.position, Quaternion.identity);
        Destroy(this.gameObject);
    }
}
