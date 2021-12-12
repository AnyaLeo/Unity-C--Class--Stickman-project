using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grab : MonoBehaviour
{
    public KeyCode mouseButton = KeyCode.Mouse0;

    private bool canGrabObjects;
    private FixedJoint2D joint;

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
        }
    }
}
