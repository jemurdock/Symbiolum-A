using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockPlayer : MonoBehaviour
{
    public Host host;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.transform.GetComponent<Player>() != null)
        {
            host = other.transform.GetComponent<Player>().host;
            if (host != null && host.water)
            {
                transform.Find("Wall").GetComponent<BoxCollider>().enabled = false;
                transform.Find("Wall2").GetComponent<BoxCollider>().enabled = false;
                transform.Find("Wall3").GetComponent<BoxCollider>().enabled = false;
                transform.Find("Wall4").GetComponent<BoxCollider>().enabled = false;
                transform.Find("Wall5").GetComponent<BoxCollider>().enabled = false;

            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        transform.Find("Wall").GetComponent<BoxCollider>().enabled = true;
        transform.Find("Wall2").GetComponent<BoxCollider>().enabled = true;
        transform.Find("Wall3").GetComponent<BoxCollider>().enabled = true;
        transform.Find("Wall4").GetComponent<BoxCollider>().enabled = true;
        transform.Find("Wall5").GetComponent<BoxCollider>().enabled = true;
    }
}
