using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreScript2 : MonoBehaviour
{
    Text uitext;
    public int score = 0;
    PlayerCtrl playerscore;
    // Use this for initialization
    void Start()
    {
        playerscore = GameObject.Find("Player").GetComponent<PlayerCtrl>();
        uitext = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        uitext.text = (playerscore.score).ToString();
    }
}
