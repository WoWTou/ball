using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody rb;
    float inputX;
    float inputY;
    public float Speed;

    private Vector3 movementInput;

    private void Update()
    {
        playerInput();
    }

    private void FixedUpdate()
    {
        Movement();
    }
    private void playerInput()
    {
        inputX = Input.GetAxis("Horizontal");
        inputY = Input.GetAxis("Vertical");


    }

    private void Movement()
    {
        transform.Translate(Vector3.right * inputX * Speed);
        transform.Translate(Vector3.forward * inputY * Speed);
    }


}
