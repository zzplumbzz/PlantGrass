using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    public Animator animator;
    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        // Vector3 pos = transform.position;
        // if(Input.GetKey(KeyCode.W))
        // {
        //     pos.y += speed * Time.deltaTime;
        // }

        // if (Input.GetKey(KeyCode.S))
        // {
        //     pos.y -= speed * Time.deltaTime;
        // }

        // if (Input.GetKey(KeyCode.D))
        // {
        //     pos.x += speed * Time.deltaTime;
        // }

        // if (Input.GetKey(KeyCode.A))
        // {
        //     pos.x -= speed * Time.deltaTime;
        // }
        // transform.position = pos;

         animator.SetFloat("Horizontal", movement.x);
         animator.SetFloat("Vertical", movement.y);
         animator.SetFloat("Speed", movement.sqrMagnitude);
        //rb.velocity = new Vector2(0, 0);
    }

    private void FixedUpdate() 
    {
        //rb.velocity = new Vector2(0,0);
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
