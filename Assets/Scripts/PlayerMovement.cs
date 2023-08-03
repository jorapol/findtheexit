using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    Vector3 move;

    void Start()
    {
        
    }

    void FixedUpdate()
    {
        //translate character in the direction of the input keys 
        move = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        transform.Translate(move * speed * Time.deltaTime);
    }
}
