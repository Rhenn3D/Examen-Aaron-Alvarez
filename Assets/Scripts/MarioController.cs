using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarioController : MonoBehaviour
{
    private Rigidbody2D rb2D;
    private float inputHorizontal;
    public float playerSpeed = 4;
    public float jumpForce = 15;
    public GroundSensor groundSensor;
    public bool isGrounded;
    
    

    
    void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
        groundSensor = FindObjectOfType<GroundSensor>();
        isGrounded = GetComponentInChildren<GroundSensor>();
    }

    void FixedUpdate()
    {
        inputHorizontal = Input.GetAxisRaw("Horizontal");
     
        rb2D.velocity = new Vector2(playerSpeed * inputHorizontal, rb2D.velocity.y);
        
    }

    void Update()
    {

        if(Input.GetButtonDown("Jump")) //Se que me falta el && isGrounded y el GetComponentInChildren pero no sabia como ponerlo
        {
            Jump();
        }
        if(inputHorizontal > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else if(inputHorizontal < 0)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
    }

    void Jump()
    {
       rb2D.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }



   
}
