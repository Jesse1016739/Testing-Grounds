using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 6.0f;
    public float jumpForce = 8.0f;
    public float gravity = 20.0f;
    public float rotSpeed = 90f;

    private Vector3 moveDirection = Vector3.zero;
    private CharacterController controller;

    // Start is called before the first frame update
    void Start()
    {
        //store our controller
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(controller.isGrounded)
        {
            moveDirection = new Vector3(0, 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;

            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpForce;
            }
            //location alpha

        }

        //rotation code we totally figured out by ourselves
        //if you don't want to rotate in the air move this to location alpha
        transform.Rotate(0, Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime, 0);
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
        
        /*
        if(moveDirection != Vector3.zero)
        {
            transform.forward = Vector3.Lerp(transform.forward, new Vector3(moveDirection.x, 0, moveDirection.z).normalized,0.5f);
        }
        Debug.Log(Input.GetAxis("Horizontal"));
        */
        
    }
}
