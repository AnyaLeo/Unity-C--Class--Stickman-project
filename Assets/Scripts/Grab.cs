using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grab : MonoBehaviour
{
    public KeyCode mouseButton = KeyCode.Mouse0;

    private bool canGrabObjects;
    private FixedJoint2D joint;

    private void Start()
    {
        joint = gameObject.AddComponent<FixedJoint2D>();
        joint.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(mouseButton))
        {
            canGrabObjects = true;
        }
        else
        {
            canGrabObjects = false;
            joint.enabled = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (canGrabObjects)
        {
            Rigidbody2D objectRb = collision.transform.GetComponent<Rigidbody2D>();
            if (objectRb != null)
            {
                joint.enabled = true;
                joint.connectedBody = objectRb;
            }
        }
    }
}
