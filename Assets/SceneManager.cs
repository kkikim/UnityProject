﻿using UnityEngine;
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
	}
}
