using UnityEngine;
using System.Collections;

public class FireInGround : MonoBehaviour {

	// Use this for initialization
	void Start () 
    {
	    Invoke("DestroyThis",10.0f);
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * 10, ForceMode2D.Impulse);
	}
	
	// Update is called once per frame
	void Update () {
	
        
	}
    void DestroyThis()
    {
        Destroy(this.gameObject);
    }
}
