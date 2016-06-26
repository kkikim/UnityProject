using UnityEngine;
using System.Collections;

public class CoinInGround : MonoBehaviour {
    public timescript a;
    AudioSource coinAudio;
	// Use this for initialization
	void Start () {
        coinAudio = GetComponent<AudioSource>();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.gameObject.tag == "Player")
        {
            a.remainTime += 1;
            coinAudio.Play();
            Destroy(this.gameObject);
        }
    }
}
