using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;

    // Update is called once per frame
    void Update()
    {
        // Put the camera at the same position as the player
        Vector3 playerPosition = player.position;
        playerPosition.z = (-1);
        transform.position = playerPosition;
    }
}
