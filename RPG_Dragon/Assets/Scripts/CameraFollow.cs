using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    Camera cam;
    GameObject playerRef;

    void Start()
    {
        playerRef = GameObject.FindGameObjectWithTag("Player");
    }

    void LateUpdate()
    {
        transform.position = playerRef.transform.position /*+ new Vector3(0, 1.2f, -2.25f)*/ ;
    }
}
