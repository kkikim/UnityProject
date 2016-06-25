using UnityEngine;
using System.Collections;

public class MakeCannon : MonoBehaviour {

    bool collisionThisTrigger;
    public GameObject cannon;

    public Vector2 location1;
    public Vector2 location2;
    public Vector2 location3 = new Vector2(0,-100);
	// Use this for initialization
	void Start () {
        collisionThisTrigger = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.gameObject.tag == "Player" && !collisionThisTrigger)
        {
            collisionThisTrigger = true;
            Instantiate(cannon, location1, Quaternion.identity);
            Instantiate(cannon, location2, Quaternion.identity);
            Instantiate(cannon, location3, Quaternion.identity);
        }
    
    }

}
