using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_movement : MonoBehaviour
{
    public float playerSpeed = 5f;

    public Rigidbody2D rb;
    public Animator animator;
    public float xAx, yAx;
    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if(movement.x != 0){
            xAx = movement.x;
            yAx = 0;
        }
        if(movement.y != 0){
            yAx = movement.y;
            xAx = 0;
        }
            
        animator.SetFloat("Horizontal",xAx);
        animator.SetFloat("Vertical",yAx);
        animator.SetFloat("Speed",movement.sqrMagnitude);
        
        movement.Normalize();

        rb.velocity = movement * playerSpeed;
    }


}
