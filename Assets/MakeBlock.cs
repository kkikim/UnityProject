using UnityEngine;
using System.Collections;

public class MakeBlock : MonoBehaviour {

    public Vector2 location1 = new Vector2(-100,-100);
    public Vector2 location2= new Vector2(-100,-100);
    public Vector2 location3= new Vector2(-100,-100);
    public Vector2 location4= new Vector2(-100,-100);
    public GameObject Block;
    bool collisionThisTrigger;
	// Use this for initialization
	void Start () {
        collisionThisTrigger = false;
	}
	
	// Update is called once per frame
	void Update () {
	}
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player" && !collisionThisTrigger)
        {
            collisionThisTrigger = true;
            Instantiate(Block, location1, Quaternion.identity);
            Instantiate(Block, location2, Quaternion.identity);
            Instantiate(Block, location3, Quaternion.identity);
            Instantiate(Block, location4, Quaternion.identity);
        }

    }
}
