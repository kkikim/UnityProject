using UnityEngine;
using System.Collections;

public class spinyspawn : MonoBehaviour {

    public GameObject spiny;
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
        if (coll.gameObject.tag == "Player")
        {
            Instantiate(spiny, new Vector2(80.0f, -3.82f), Quaternion.identity);
        }
    }
}
