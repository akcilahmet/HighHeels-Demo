using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PlayerMoveControl : MonoBehaviour
{
    
    public float Horspeed = 300f;
    public float walkingSpeed = 200f;
    float tempSpeed;


    public static bool rotateControl;

    public DynamicJoystick variableJoystick;
    public Rigidbody rb;
    Animator anim;

    bool balanceObjControl;
    float randomValue;


    private void Start()
    {
        tempSpeed = walkingSpeed;
        walkingSpeed = 0;

        balanceObjControl = false;

        anim = GetComponent<Animator>();

        randomValue = UnityEngine.Random.Range(0.12f, -0.12f);

    }

    public void runStart()
    {
        anim.SetTrigger("walkingprm");

        walkingSpeed = tempSpeed;
        DOTween.To(() => walkingSpeed, x => walkingSpeed = x, tempSpeed, 1);
    }
    public void FixedUpdate()
    {
        moveControl();
        rotControl();
       
    }
    void moveControl()
    {
        Vector3 move;
        if (balanceObjControl == false)
        {
             move = new Vector3(variableJoystick.Horizontal * Horspeed * Time.fixedDeltaTime, rb.velocity.y, walkingSpeed * Time.fixedDeltaTime);
            rb.velocity = move;

        }
        else
        {
            transform.Translate(0, 0, 3 * Time.fixedDeltaTime);

        }

    }

    void rotControl()
    {
        if (balanceObjControl == true)
        {
            transform.Rotate(0, 0, randomValue- variableJoystick.Horizontal);
           
        }
    }


    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "balancetag")
        {
            transform.Rotate(0, 0, randomValue);
            balanceObjControl = true;

            anim.SetBool("balanceprm", true);

            

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "balancetag")
        {
            balanceObjControl = false;
            anim.SetBool("balanceprm", false);
            transform.localEulerAngles=new Vector3(0,0, 0);

        }
    }



}
