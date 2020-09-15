using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class position : MonoBehaviour
{
    public GameObject player;
    public GameObject updater;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Vector3 pos;
        pos.x = (player.transform.position.x + ((player.GetComponent<Rigidbody>().velocity.x / Mathf.Abs(player.GetComponent<Rigidbody>().velocity.x)) * 2));
        pos.y = player.transform.position.y;
        pos.z = -10;
        transform.position = pos;
        Debug.Log(pos);
        
    }
}
