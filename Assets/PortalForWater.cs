using UnityEngine;
using System.Collections;

public class PortalForWater : MonoBehaviour
{

    PlayCtrlInWater portalstate;
    // Use this for initialization
    void Start()
    {
        portalstate = GameObject.Find("Player").GetComponent<PlayCtrlInWater>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")
            portalstate.portal = true;


    }
    void OnTriggerStay2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")
            print("머무는중");
    }
    void OnTriggerExit2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")
            portalstate.portal = false;
    }
}
