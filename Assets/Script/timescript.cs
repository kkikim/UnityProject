using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class timescript : MonoBehaviour {
    Text uitext;
    public float remainTime;
	// Use this for initialization
	void Start () {
        remainTime = 150;
        uitext = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        remainTime -= Time.deltaTime;
        if(remainTime<0)
        {
            Application.LoadLevel(Application.loadedLevel);
        }
        uitext.text = ((int)remainTime).ToString();
	}
}
