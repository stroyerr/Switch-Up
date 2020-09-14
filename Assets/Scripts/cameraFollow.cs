using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{

    public Transform player;
    public GameObject playerObject;
    private Rigidbody rb;
    private float posX = 0f;
    private float posY = 0f;
    private Vector3 pos;
    public float zOffset = 20f;
    public float minimumOffset = 10f;

    private void Start()
    {
        rb = playerObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        pos.x = player.position.x;
        pos.y = player.position.y + (0.3f*(Mathf.Abs(rb.velocity.magnitude) * zOffset + minimumOffset));
        //pos.z = -Mathf.Abs(rb.velocity.x + 1) * zOffset;
        pos.z = 10f;
        transform.position = pos;
        Camera.main.orthographicSize = (Mathf.Abs(rb.velocity.magnitude) * zOffset + minimumOffset);
    }
}
