using UnityEngine;
using System.Collections;

public class SceneManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
        if(Input.GetKey(KeyCode.Alpha1))
        {
            Application.LoadLevel(Application.loadedLevelName);
        }

        if (Input.GetKey(KeyCode.Alpha2))
        {
            Application.LoadLevel(0);
        }
        if (Input.GetKey(KeyCode.Alpha3))
        {
            Application.LoadLevel(1);
        }
        if (Input.GetKey(KeyCode.Alpha4))
        {
            Application.LoadLevel(2);
        }
        if (Input.GetKey(KeyCode.Alpha5))
        {
            Application.LoadLevel(3);
        }
	}
}
