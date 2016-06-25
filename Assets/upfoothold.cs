using UnityEngine;
using System.Collections;

public class upfoothold : MonoBehaviour {
    public float TimeLeft = 1.0f;
    float nextTime = 0.0f;
    public GameObject foothold;
	// Use this for initialization
	void Start () {
	

	}
	
	// Update is called once per frame
	void Update () {
        if (Time.time > nextTime)
        {
            nextTime = Time.time + TimeLeft;
            Instantiate(foothold, new Vector2(this.transform.position.x , this.transform.position.y ), Quaternion.identity);

        }
	}
}
