using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarbarainCharacterController : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            anim.SetBool("walk", true);
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            anim.SetBool("walk", false);
            anim.SetBool("run", true);
        }
    }
}
