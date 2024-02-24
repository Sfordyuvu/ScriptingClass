using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This is for a 2D project because I want to make more work for myself YIPEE
/// </summary>

public class PlayerController : MonoBehaviour
{
    //decliar variables
[SerializeField] private float moveSpeed = 5f;
[SerializeField] private float jumpForce = 40f;

private float xSpeed = 0f;
private Rigidbody2D Ridg;
private Vector3 moveDirection = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        Ridg = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetButtonDown("Jump")){ //jump input
            Ridg.velocity += new Vector2(0f, jumpForce); //adds jump force to total velocity of the rigidbody
        }
        xSpeed = Input.GetAxisRaw("Horizontal") * moveSpeed; //gets user input and multiplies by movespeed
        Vector3 targetVelocity = new Vector2(xSpeed, Ridg.velocity.y); //assigns both x and y velocity to one variable
        Ridg.velocity = targetVelocity; //assigns the velocity to the rigid body
        
        
    }
}
