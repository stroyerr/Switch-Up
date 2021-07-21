using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{

    public GameObject player;
    float distance;

    // Update is called once per frame
    void Update()
    {
        distance = Mathf.Abs(player.transform.position.x - transform.position.x);

    }

    private void FixedUpdate()
    {
        if (distance > 200)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(this.gameObject);
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "die")
        {
            Destroy(col.gameObject);
        }
    }


}
