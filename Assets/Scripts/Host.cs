using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Animal { Bear, Deer, Rabbit, Fish, Fox };

public class Host : MonoBehaviour
{
    public float size;
    public bool water;
    public float speed;
    public float jumpSpeed;
    public float yOffset;
    public float xOffset;
    public float zOffset;
    public Animal type;
    public bool skill_active;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void activate()
    {
        switch (type)
        {
            case Animal.Bear:              
                break;
            case Animal.Fox:
                transform.GetComponent<ParticleSystem>().Play();
                transform.GetComponent<CapsuleCollider>().enabled = false;
                GameObject[] logs = GameObject.FindGameObjectsWithTag("Log");
                foreach (GameObject l in logs)
                {
                    l.GetComponent<CapsuleCollider>().enabled = false;
                }
                transform.GetChild(0).GetChild(0).GetComponent<MeshRenderer>().enabled = false;
                break;
            case Animal.Fish:
                break;
            case Animal.Rabbit:
                break;
        }
        skill_active = true;
    }

    public void deactivate()
    {
        switch (type)
        {
            case Animal.Bear:
                break;
            case Animal.Fox:
                transform.GetComponent<ParticleSystem>().Stop();
                transform.GetComponent<CapsuleCollider>().enabled = true;
                GameObject[] logs = GameObject.FindGameObjectsWithTag("Log");
                foreach(GameObject l in logs)
                {
                    l.GetComponent<CapsuleCollider>().enabled = true;
                }
                transform.GetChild(0).GetChild(0).GetComponent<MeshRenderer>().enabled = true;
                break;
            case Animal.Fish:
                break;
            case Animal.Rabbit:
                break;
        }
        skill_active = false;
    }

}
