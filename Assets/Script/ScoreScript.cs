using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {
    Text uitext;
    PlayCtrlInWater playerscore;
    public int score=0;
    // Use this for initialization
    void Start()
    {
        playerscore = GameObject.Find("Player").GetComponent<PlayCtrlInWater>();
        uitext = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        //uitext.text = score.ToString();
    }
}
