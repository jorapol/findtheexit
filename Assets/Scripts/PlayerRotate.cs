using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotate : MonoBehaviour
{
    public float magnitude = 25f;
    void Update()
    {
        transform.LookAt(new Vector3(
            Input.GetAxisRaw("Horizontal") * magnitude + transform.position.x,
            0,
            Input.GetAxisRaw("Vertical") * magnitude + transform.position.y
            )
        );

    }
}
