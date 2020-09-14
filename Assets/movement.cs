using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

    public Rigidbody rb;
    public float horizontalSpeed = 50f;
    private float horizontalAxis = 0f;
    private float horzMove = 0f;
    public float jumpSpeed = 20f;
    private float jumping = 0f;

    void Update()
    {
        horizontalAxis = Input.GetAxis("Horizontal");
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumping = jumpSpeed;
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            jumping = 0f;
        }
    }

    private void FixedUpdate()
    {
        Debug.Log(jumping);
        horzMove = horizontalAxis * horizontalSpeed;
        rb.AddForce(horzMove, 0, 0);
        rb.AddForce(0, 20, 0);
        Debug.Log((horzMove, jumping, 0));
    }
}
