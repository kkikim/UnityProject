using UnityEngine;
using System.Collections;

public class transUpfoothold : MonoBehaviour {

	// Use this for initialization
	void Start () {

        Invoke("DestroyThisObject", 10.0f);
	}
	
	// Update is called once per frame
	void Update () {

        transform.Translate(Vector2.up * 2 * Time.deltaTime);
	}
    void OnTriggerEnter2D(Collider2D coll)
    {
  

    }
    void DestroyThisObject()
    {
        Destroy(this.gameObject);
    }
}
