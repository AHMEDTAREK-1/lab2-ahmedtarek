using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float movespeed;

    public float jumph;

    public KeyCode space;

    public KeyCode l;

    public KeyCode r;

    void Update()
                   {

if(Input.GetKeyDown(space) && grounded)
{
    Jump();
}

if (Input.GetKey(l))
{
    GetComponent<Rigidbody2D>().velocity = new Vector2(-movespeed, GetComponent<Rigidbody2D>().velocity.y);

    if(GetComponent<SpriteRenderer>()!=null)
    {
        GetComponent<SpriteRenderer>().flipX = true;
    }
}

if (Input.GetKey(r))
{
    GetComponent<Rigidbody2D>().velocity = new Vector2(movespeed, GetComponent<Rigidbody2D>().velocity.y);

    if(GetComponent<SpriteRenderer>()!=null)
    {
        GetComponent<SpriteRenderer>().flipX = false;
    }
}

}

void Jump()
{
    GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumph);
}

public Transform groundCheck;
public float groundCheckRadius;
public LayerMask whatIsGround;
private bool grounded;

void FixedUpdate(){

grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
}
        
 }