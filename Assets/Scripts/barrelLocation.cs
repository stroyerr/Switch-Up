using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrelLocation : MonoBehaviour
{

    public GameObject player;
    public float displacement = 1f;

    // Update is called once per frame
    void Update()
    {
        Vector3 pos;
        pos.y = player.transform.position.y;
        pos.z = player.transform.position.z;
        pos.x = player.transform.position.x + (player.GetComponent<Rigidbody>().velocity.x / Mathf.Abs(player.GetComponent<Rigidbody>().velocity.x) * displacement);
        transform.position = pos;
    }
}
