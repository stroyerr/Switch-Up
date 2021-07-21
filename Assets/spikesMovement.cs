using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spikesMovement : MonoBehaviour
{
    public Vector3 initialPosition;
    public int frequency = 100;

    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = -frequency; i < frequency; i++)
        {
            transform.position = new Vector3(initialPosition.x, i * frequency, initialPosition.z);
        }
    }

    private void FixedUpdate()
    {
        
    }
}
