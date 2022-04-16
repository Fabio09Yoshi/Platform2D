using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public FixedJoystick moveJoystick;
    public CharacterController2D controller;
    public Animator anim;
    public float runSpeed = 40f;
    float horizontalMove = 0f;
    bool jump = false;
    bool attack;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        horizontalMove = moveJoystick.Horizontal * runSpeed;


        anim.SetFloat("Speed", Mathf.Abs(horizontalMove));

        //if (Input.GetButtonDown("Jump"))
        //{
        //    anim.SetBool("isJumping", true);
        //    jump = true;
        //}

    }

    public void Attack()
    {

        anim.SetTrigger("Attack"); 

    }
    public void Jump()
    {
        anim.SetBool("isJumping", true);
        jump = true;
        attack = false;
    }

    public void OnLanding()
    {
        anim.SetBool("isJumping", false);
        
    }

    private void FixedUpdate()
    {
        //Movement 
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;

    }
}
