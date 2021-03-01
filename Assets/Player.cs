using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public InputAction wasd;
    private Animator anim;
    private CharacterController controller;
   

    public float speed = 600.0f;
    public float turnSpeed = 400.0f;
    private Vector3 moveDirection = Vector3.zero;
    public float gravity = 20.0f;


    void Start()
    {
        controller = GetComponent<CharacterController>();
        anim = gameObject.GetComponentInChildren<Animator>();
    }

    private void OnEnable()
    {
        wasd.Enable();
    }

    private void OnDisable()
    {
        wasd.Disable();
    }

    void Update()
    {
        Vector2 inputVector = wasd.ReadValue<Vector2>();
        Vector3 vectorfinale = new Vector3();
        vectorfinale.x = inputVector.x;
        vectorfinale.z = inputVector.y;

        //if (Input.GetKey("w"))
        //{
        //    anim.SetInteger("AnimationPar", 1);
        //}
        //else
        //{
        //    anim.SetInteger("AnimationPar", 0);
        //}

        //if (controller.isGrounded)
        //{
        //    moveDirection = transform.forward * Input.GetAxis("Vertical") * speed;
        //}
        if (inputVector.magnitude != 0)
        {
            anim.SetInteger("AnimationPar", 1);
        }
        else
        {
            anim.SetInteger("AnimationPar", 0);
        }

        
       // float turn = vectorfinale.x;
        //transform.Rotate(turn, turn * turnSpeed * Time.deltaTime, 0);
        controller.Move(vectorfinale * Time.deltaTime);
        moveDirection.y -= gravity * Time.deltaTime;
        Debug.Log(wasd.ReadValue<Vector2>().ToString());
    }

}
