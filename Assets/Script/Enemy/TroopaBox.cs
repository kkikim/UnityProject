using UnityEngine;
using System.Collections;

public class TroopaBox : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Shell")
        {
            
            //Destroy(this.gameObject);
            Destroy(this.transform.parent);
        }
        if (coll.gameObject.tag == "Fireball")// 미사일
        {
           
            //Destroy(this.gameObject);
            Destroy(this.transform.parent);
        }
    }
}
