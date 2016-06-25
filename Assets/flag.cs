using UnityEngine;
using System.Collections;

public class flag : MonoBehaviour {
    public bool translate = false;
    GameObject castleDoor;
	// Use this for initialization
	void Start () {
        castleDoor = GameObject.Find("Door");
	}
	
	// Update is called once per frame
	void Update () 
    {
	    if(translate)
        {
            transform.Translate(Vector2.down *2.0f * Time.deltaTime);
            if(this.transform.position.y<-2.5f)
            {
                translate = false;
                Destroy(castleDoor);
            }
        }
	}
}
