using UnityEngine;
using System.Collections;

public class GameEnding : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Invoke("GameEnd", 10.0f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void GameEnd()
    {
        Application.Quit();
    }
}
