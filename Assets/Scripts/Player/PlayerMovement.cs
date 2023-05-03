using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;

    public Animator anim;
    public float moveSpeed, x, y;

    private bool isMoving;
    private Vector3 moveDirection;

    private void Start()
    {
      rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
      x = Input.GetAxisRaw("Horizontal");
      y = Input.GetAxisRaw("Vertical");

      if ( x != 0 || y != 0 )
      {
        anim.SetFloat("X", x);
        anim.SetFloat("Y", y);

        if ( !isMoving )
        {
          isMoving = true;
          anim.SetBool("isMoving", isMoving);
        }
      }else
      {
        if ( isMoving )
        {
          isMoving = false;
          anim.SetBool("isMoving", isMoving);
          StopMoving();
        }
      }

      moveDirection = new Vector3( x, y ).normalized;
    }

    private void FixedUpdate()
    {
      rb.velocity = moveDirection * moveSpeed * Time.deltaTime;
    }

    private void StopMoving()
    {
      rb.velocity = Vector3.zero;
    }
}
