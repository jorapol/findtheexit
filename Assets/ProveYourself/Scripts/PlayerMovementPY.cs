using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementPY : MonoBehaviour
{
    public float speed;
    Vector3 moveH;

    void Start()
    {
        
    }

    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        moveH = new Vector3(Input.GetAxisRaw("Horizontal"), 0, 0);
        transform.Translate(moveH * speed * Time.deltaTime);
    }
}
