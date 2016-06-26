using UnityEngine;
using System.Collections;

public class Title : MonoBehaviour {
    bool start = false;
    Animator marioAni;
	// Use this for initialization
	void Start () {
        marioAni = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.anyKeyDown)
        {
            Invoke("StartGame", 3.0f);
            start = true;
        }
        if(start)
        {
            marioAni.Play("right_walk");
            transform.Translate(Vector2.right * 5 * Time.deltaTime);
        }
	}
    void StartGame()
    {
        Application.LoadLevel(Application.loadedLevel + 1);
    }
}
