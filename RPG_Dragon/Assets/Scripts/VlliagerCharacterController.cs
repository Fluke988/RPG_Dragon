using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VlliagerCharacterController : MonoBehaviour
{
    public Animator anim;
    public float villagerSpeed;
    Vector3 movedirection = Vector3.zero;
    float horizontalX, verticalY;
    bool toRun = false;
    bool toAttack = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))//run
        {
            toRun = true;
        }
        else if (Input.GetKeyUp(KeyCode.R))
        {
            toRun = false;
        }
        anim.SetBool("isRunning", toRun);
        if (Input.GetKeyDown(KeyCode.Q))//attack
        {
            toAttack = true;
            anim.SetBool("isAttacking", toAttack);
        }
        if (Input.GetKeyUp(KeyCode.Q))
        {
            toAttack = false;
            anim.SetBool("isAttacking", toAttack);
        }
        if (Input.GetKeyDown(KeyCode.E))//punch
        {
            anim.SetTrigger("isPunching");
        }
    }
    void FixedUpdate()
    {
        horizontalX = Input.GetAxis("Horizontal");
        verticalY = Input.GetAxis("Vertical");
        villagerSpeed = new Vector2(horizontalX, verticalY).sqrMagnitude;
        anim.SetFloat("isWalking", villagerSpeed);
    }
}
