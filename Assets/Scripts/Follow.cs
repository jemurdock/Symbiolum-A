// Smooth towards the target

using UnityEngine;
using System.Collections;

public class Follow : MonoBehaviour
{
    public Transform target;
    public float smoothTime = 0.3F;
    private Vector3 velocity = Vector3.zero;
    public float speed = 1;
    public float turnSpeed = 4.0f;
   // private Vector3 offset;

    void Start()
    {
        //offset = new Vector3(target.position.x, target.position.y + 5.0f, target.position.z + 12.0f);
    }

    void Update()
    {
        // Define a target position above and behind the target transform
        Vector3 targetPosition = target.TransformPoint(new Vector3(0, 15, -12));

        // Smoothly move the camera towards that target position
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);

        //transform.position = new Vector3(target.position.x, target.position.y + 8.0f, target.position.z + 7.0f);

        transform.LookAt(target.position);

        //transform.RotateAround(target.transform.position, Vector3.up, Input.GetAxis("Mouse X") * turnSpeed);
    }

   /*void LateUpdate()
    {
        offset = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * turnSpeed, Vector3.right) * offset;
        transform.position = target.position + offset;
        transform.LookAt(target.position);
    }*/
}
