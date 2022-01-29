using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingMeteor : MonoBehaviour
{
    public float meteorSpeed = 10f;
    Transform threshold;

    private void OnEnable()
    {
        threshold = GameObject.Find("MeteorThreshold").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * Time.deltaTime * meteorSpeed);

        bool isMeteorAboveThreshold = transform.position.y >= threshold.position.y;
        if(!isMeteorAboveThreshold)
        {
            Destroy(gameObject);
        }
    }
}
