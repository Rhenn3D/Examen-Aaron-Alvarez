using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSensor : MonoBehaviour
{
    public bool isGrounded = false;
    public GroundSensor groundSensor;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.layer == 3)
        {
            isGrounded = true;
        }
        
    }
}
