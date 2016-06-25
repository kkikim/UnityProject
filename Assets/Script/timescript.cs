using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class timescript : MonoBehaviour {
    Text uitext;
    static float remainTime;
	// Use this for initialization
	void Start () {
        remainTime = 300;
        uitext = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        remainTime -= Time.deltaTime;

        uitext.text = ((int)remainTime).ToString();
	}
}
