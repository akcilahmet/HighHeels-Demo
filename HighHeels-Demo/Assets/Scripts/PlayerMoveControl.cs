using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PlayerMoveControl : MonoBehaviour
{
    public float Horspeed = 300;

    public float walkingSpeed = 200;
    float tempSpeed;

    public DynamicJoystick variableJoystick;
    public Rigidbody rb;
    Animator anim;


    private void Start()
    {
        tempSpeed = walkingSpeed;
        walkingSpeed = 0;

        anim = GetComponent<Animator>();
        //anim.SetFloat("verticalprm", 0f);

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
    }
    void moveControl()
    {

        Vector3 move = new Vector3(variableJoystick.Horizontal * Horspeed * Time.fixedDeltaTime, rb.velocity.y, walkingSpeed * Time.fixedDeltaTime);
        rb.velocity = move;
        //anim.SetFloat("horizontalprm", variableJoystick.Horizontal);
        //anim.SetFloat("verticalprm", 1);

    }




}
