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
    public GameObject updater;
    public float fireMultiplier = 2f;
    private int jumps = 0;
    private bool lowGravity = false;
    private bool lGrav = false;

    void Stat()
    {
        Physics.gravity = new Vector3(0, -10, 0);
    }

    void Update()
    {
        horizontalAxis = Input.GetAxis("Horizontal");
        if (Input.GetKeyDown(KeyCode.Space) && GroundCheck())
        {
            jumping = jumpSpeed;
        }        
      
        if (updater.GetComponent<themeController>().theme == 1)
        {
            horzMove = fireMultiplier * horizontalAxis * horizontalSpeed;
        }
        else
        {
             horzMove = horizontalAxis * horizontalSpeed;
        }
        //if (Input.GetKeyUp(KeyCode.Space))
        //{
        //    jumping = 0f;
        //}

        if (updater.GetComponent<themeController>().theme == 2)
        {
            lowGravity = true;
        }
        else
        {
            lowGravity = false;
        }
    }

    private void lowGrav(bool input)
    {
        if (input)
        {
            Physics.gravity = new Vector3(0, -4, 0);
        }
        else
        {
            Physics.gravity = new Vector3(0, -10, 0);
        }
    }

    private void FixedUpdate()
    {
        if (lowGravity)
        {
            if (lowGravity != lGrav)
            {
                lowGrav(true);
                lGrav = true;
            }
        }
        else
        {
            if (!lowGravity)
            {
                if(lowGravity != lGrav)
                {
                    lowGrav(false);
                    lGrav = false;
                }
            }
        }


        rb.AddForce(Vector3.up * jumping);

        

        rb.AddForce(horzMove, 0, 0);
        
        jumping = 0f;

       
    }
    //Ground check script credit: https://www.reddit.com/r/Unity3D/comments/3c43ua/best_way_to_check_for_ground/
    bool GroundCheck()
    {
        RaycastHit hit;
        float distance = 1f;
        Vector3 dir = new Vector3(0, -1);


        if (updater.GetComponent<themeController>().theme == 0)
        {
            if (jumps < 1)
            {
                jumps += 1;
                return true;
            }
            else
            {
                if (Physics.Raycast(transform.position, dir, out hit, distance))
                {
                    jumps = 0;
                    return true;
                }
                    return false;
            }
        }
        else
        {
            if (Physics.Raycast(transform.position, dir, out hit, distance))
            {
                jumps = 0;
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
