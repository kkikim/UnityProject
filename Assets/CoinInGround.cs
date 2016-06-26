using UnityEngine;
using System.Collections;

public class CoinInGround : MonoBehaviour {
    public timescript a;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.gameObject.tag == "Player")
        {
            a.remainTime += 1;
            Destroy(this.gameObject);
        }
    }
}
