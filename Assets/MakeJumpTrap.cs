using UnityEngine;
using System.Collections;

public class MakeJumpTrap : MonoBehaviour {

    public GameObject JumpTrap;
    
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
	

	}
    void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.gameObject.tag == "Player")
            Instantiate(JumpTrap, new Vector2(this.transform.position.x+5 , this.transform.position.y - 2.5f), Quaternion.identity);
    }
}
