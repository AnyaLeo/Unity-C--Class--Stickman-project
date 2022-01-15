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
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();

        // IF animator is private, include this line:
        anim = GetComponentInParent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // if we press A OR arrow key left
        // then go left
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(Vector2.left * playerSpeed);

            // Include the EXACT name of the state you want to play
            // the state is the box you see in the animator
            anim.Play("Walk");
        }
        // if we press D OR arrow key right
        // then go right 
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(Vector2.right * playerSpeed);

            anim.Play("Walk");
        }
        else
        {
            anim.Play("Idle");
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
