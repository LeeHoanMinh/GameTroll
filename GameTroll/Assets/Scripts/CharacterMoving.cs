using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMoving : MonoBehaviour
{
    public CharacterController2D controller;
    public float runSpeed = 40f;
    float horizontalMove = 0f;
    void Start()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
    }

    // Update is called once per frame
    void Update()
    {
       
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, false);
    }
}
