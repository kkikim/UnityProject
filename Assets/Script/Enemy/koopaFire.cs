using UnityEngine;
using System.Collections;

public class koopaFire : MonoBehaviour {
    public GameObject fireParticle;
    float velocity;
    KoopaAI KoopaScript;
    Vector2 moveDirection;
	// Use this for initialization
	void Start () 
    {
        velocity = 10.0f;
        KoopaScript = GameObject.Find("Koopa").GetComponent<KoopaAI>();
        moveDirection = KoopaScript.directionVector;
	}
	
	// Update is called once per frame
	void Update () 
    {
        if(moveDirection.x == 1)
        {
            Vector3 scale = transform.localScale;
            scale.x = -Mathf.Abs(scale.x);
            transform.localScale = scale;
        }
        transform.Translate(Time.deltaTime * velocity * moveDirection);
        Destroy(this.gameObject, 50.0f);
	}
    void OnCollisionEnter2D()
    {
        Instantiate(fireParticle, this.transform.position, Quaternion.identity);
        Destroy(this.gameObject);
    }
}
