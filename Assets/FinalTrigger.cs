using UnityEngine;
using System.Collections;

public class FinalTrigger : MonoBehaviour {
    public GameObject wall;
    public GameObject Koopa;
    public GameObject flowerSpawn;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.gameObject.tag == "Player")
        {
            Instantiate(wall, new Vector2(240.5f, 0.5f), Quaternion.identity);
            Instantiate(wall, new Vector2(240.5f, 1.5f), Quaternion.identity);
            Instantiate(wall, new Vector2(240.5f, 2.5f), Quaternion.identity);
            Koopa.SetActive(true);
            flowerSpawn.SetActive(true);
        }
    }
}
