using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spikeBounce : MonoBehaviour
{
    private Vector3 _startPosition;
    public float speed = 1f;
    public float offset = 1f;
    public float initialZ = 17f;

    void Start()
    {
        _startPosition = transform.position;
    }

    void Update()
    {
        if (!GetComponent<properties>().alive)
        {
            return;
        }
        transform.position = _startPosition + new Vector3(Mathf.Sin(Time.time) * speed + offset, 0.0f, initialZ) ;
    }
}
