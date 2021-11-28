using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    public float moveSpeed = 300f;
    public KeyCode mouseButton = KeyCode.Mouse0;

    Rigidbody2D rb;
    Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        // calculations
        Vector3 difference = cam.ScreenToWorldPoint(Input.mousePosition) - transform.position;

        // rotate our arm in the direction of the mouse
    }
}
