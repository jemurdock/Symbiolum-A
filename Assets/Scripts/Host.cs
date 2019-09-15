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
    public Animal type;
    public bool skill_active;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

        }

    }

    private void activate()
    {
        switch (type)
        {
            case Animal.Bear:              
                break;
            case Animal.Deer:
                break;
            case Animal.Fish:
                break;
            case Animal.Rabbit:
                break;
            default:
                break;
        }
    }

}
