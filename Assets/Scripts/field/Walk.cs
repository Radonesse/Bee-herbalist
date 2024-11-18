using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : MonoBehaviour
{
    private Rigidbody2D RB_Bee;
    public float speedHor = 3f, speedVer = 2f;
    public Animator anim;
    private Vector2 moveVector;

    private void Awake(){
        RB_Bee = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void FixedUpdate(){
        Walking();
    }

    private void Walking(){
        StopAnimation();
        moveVector = new Vector2(Input.GetAxis("Horizontal")*speedHor, Input.GetAxis("Vertical")*speedVer);
        RB_Bee.velocity = transform.TransformDirection(moveVector);
        StartAnimation();
    }

    private void StopAnimation(){
        anim.SetBool("W", false);
        anim.SetBool("A", false);
        anim.SetBool("S", false);
        anim.SetBool("D", false);
    }

    private void StartAnimation(){
        if(RB_Bee.velocity != new Vector2(0, 0)){
            if (moveVector.x > 0) anim.SetBool("D", true);
            if (moveVector.x < 0) anim.SetBool("A", true);
            if (moveVector.y > 0) anim.SetBool("W", true);
            if (moveVector.y < 0) anim.SetBool("S", true);
        }
    }
}
