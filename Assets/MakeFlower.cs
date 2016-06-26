using UnityEngine;
using System.Collections;

public class MakeFlower : MonoBehaviour {
    public GameObject flower;
    float TimeLeftOfFlower = 15.0f;      //쿠파 퐈이어 시간변수..//6초마다 발사
    float nextTimeOfFlower = 0.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Time.time > nextTimeOfFlower)
        {
            nextTimeOfFlower = Time.time + TimeLeftOfFlower;
            Instantiate(flower,new Vector2(transform.position.x+(Random.Range(-5,5)),transform.position.y),Quaternion.identity);
        }
	
	}
}
