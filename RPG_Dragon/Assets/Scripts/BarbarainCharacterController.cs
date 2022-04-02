using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarbarainCharacterController : MonoBehaviour
{
    public Animator anim;
    public float barbarbianSpeed;
    Vector3 movedirection = Vector3.zero;
    float horizontalX, verticalY;
    bool toRun = false;
    bool toAttack = false;
    bool toPunch = false;
    //bool toDeath = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.W))
        //{
        //    //anim.SetBool("walk", true);
        //}
        //else if (Input.GetKeyDown(KeyCode.R))
        //{
        //    //anim.SetBool("walk", false);
        //    //anim.SetBool("run", true);
        //}
        if (Input.GetKeyDown(KeyCode.R))//run
        {
            toRun = true;
        }
        else if (Input.GetKeyUp(KeyCode.R))
        {
            toRun = false;
        }
        anim.SetBool("isRunning", toRun);
        if (Input.GetKey(KeyCode.Q))//attack
        {
            toAttack = true;
        }
        else if (Input.GetKeyUp(KeyCode.Q))
        {
            toAttack = false;
        }
        anim.SetBool("isAttacking", toAttack);
        if (Input.GetKeyDown(KeyCode.E))//punch
        {
            toPunch = true;
        }
        else if (Input.GetKeyUp(KeyCode.E))
        {
            toPunch = false;
        }
        anim.SetBool("isPunching", toPunch);
        if (Input.GetKeyDown(KeyCode.T))//death
        {
            // = true;
            anim.SetTrigger("isDiying");
        }
    }
    void FixedUpdate()
    {
        horizontalX = Input.GetAxis("Horizontal");
        verticalY = Input.GetAxis("Vertical");
        barbarbianSpeed = new Vector2(horizontalX, verticalY).sqrMagnitude;
        anim.SetFloat("isWalking", barbarbianSpeed);//the cahracter need to walk if ther value is > 0 
        //anim.SetFloat("Horizontal", horizontalX);//the character need to walk fast if the value is > 0.5
        //anim.SetFloat("Vertical", verticalY);//the character need to run if the value is > 1
    }
}
