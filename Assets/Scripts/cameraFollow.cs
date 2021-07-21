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
    private float cameraMode;
    public GameObject camera;
    public float scrollX;
    public float scrollY;
    public float zoomSize = 20;
    public float scrollMultiplier = 5;

    private void Start()
    {
        rb = playerObject.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        cameraMode = camera.GetComponent<zoom>().zoomType;
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            xScroll(-scrollMultiplier);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            xScroll(scrollMultiplier);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            yScroll(scrollMultiplier);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            yScroll(-scrollMultiplier);
        }
    }

    void xScroll(float scroller)
    {
        scrollX += scroller;
    }

    void yScroll(float scroller)
    {
        scrollY += scroller;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(cameraMode == 0){
        pos.x = player.position.x;
        pos.y = player.position.y + (0.3f*(Mathf.Abs(rb.velocity.magnitude) * zOffset + minimumOffset));
        //pos.z = -Mathf.Abs(rb.velocity.x + 1) * zOffset;
        pos.z = 10f;
        transform.position = pos;
        Camera.main.orthographicSize = (Mathf.Abs(rb.velocity.magnitude) * zOffset + minimumOffset);
        }else if (cameraMode == 1)
        {
            float gradual = 0;
            Vector3 newPos;
            newPos.x = 1 * scrollX;
            newPos.y = 1 * scrollY;
            newPos.z = 30;

            transform.position = newPos;
            Camera.main.orthographicSize = zoomSize;
        }
    }
}
