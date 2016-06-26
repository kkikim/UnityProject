using UnityEngine;
using System.Collections;

public class StageEndTrigger : MonoBehaviour {
    flag flag;
    bool collisionThisTrigger = false;
	// Use this for initialization
	void Start () {
        flag = GameObject.Find("flag").GetComponent<flag>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.gameObject.tag == "Player" && !collisionThisTrigger)
        {
            collisionThisTrigger = true;
            flag.translate = true;
        }
    }
}
