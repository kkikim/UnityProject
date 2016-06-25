using UnityEngine;
using System.Collections;

public class footholdDown : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        this.transform.Translate(Vector2.down * 2.0f * Time.deltaTime);
	}
}
