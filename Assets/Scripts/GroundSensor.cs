using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSensor : MonoBehaviour
{
    public bool isGrounded = false;
    public GroundSensor groundSensor;
    
    

    public void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.layer == 3)
        {
            isGrounded = true;
        }
        
    }

    public void OnTriggerExit2D(Collider2D collider)
    {
      if(collider.gameObject.layer == 3)
        {
            isGrounded = false;
        }
    }
}
