using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balance : MonoBehaviour
{
    public float targetRotation;
    public float force;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float currentRotation = rb.rotation;
        float newRotation = Mathf.LerpAngle(currentRotation, targetRotation, force * Time.deltaTime);
        rb.MoveRotation(newRotation);
    }
}
