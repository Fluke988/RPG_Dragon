using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRayCaster : MonoBehaviour
{
    //public Layer
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame

    void FixedUpdate()
    {
        int layerMask = 1 << 8;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), Mathf.Infinity, layerMask))
        {
            Debug.Log("the ray hit the player");
        }
    }
}
