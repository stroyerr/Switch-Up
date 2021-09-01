using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zoneMove : MonoBehaviour
{
    public float moveSpeed = 1f;
    public GameObject zone;

    // Start is called before the first frame update
    void Start()
    {
        zone = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
      
        {

        }
       // transform.Translate(Vector3.right * Time.deltaTime * moveSpeed);
        transform.localScale = new Vector3(transform.localScale.x + 0.02f*moveSpeed, 90, 5);
    }
}
