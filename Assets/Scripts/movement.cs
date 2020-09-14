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
        if (Input.GetKeyDown(KeyCode.Space) && GroundCheck())
        {
            jumping = jumpSpeed;
        }

        //if (Input.GetKeyUp(KeyCode.Space))
        //{
        //    jumping = 0f;
        //}
    }

    private void FixedUpdate()
    {
        horzMove = horizontalAxis * horizontalSpeed;
        rb.AddForce(horzMove, 0, 0);
        rb.AddForce(Vector3.up * jumping);
        jumping = 0f;
    }
    //Ground check script credit: https://www.reddit.com/r/Unity3D/comments/3c43ua/best_way_to_check_for_ground/
    bool GroundCheck()
    {
        RaycastHit hit;
        float distance = 1f;
        Vector3 dir = new Vector3(0, -1);

        if (Physics.Raycast(transform.position, dir, out hit, distance))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
