using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public float playerSpeed;
    public float jumpForce;
    public float distanceToGround = 0.2f;
    public Transform playerGround;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // if we press A OR arrow key left
        // then go left
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(Vector2.left * playerSpeed);
        }

        // if we press D OR arrow key right
        // then go right 
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(Vector2.right * playerSpeed);
        }

        // cast a laser (ray) downwards
        RaycastHit2D whatsBelowUs = Physics2D.Raycast(playerGround.position, Vector2.down, distanceToGround);
        // check if we hit the ground
        bool isOnGround = (whatsBelowUs.collider != null);
        // add a condition that our player can jump only if our laser hit the ground
        if (isOnGround && Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * jumpForce);
        }
    }
}
