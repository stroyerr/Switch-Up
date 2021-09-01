using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class logowobble : MonoBehaviour
{
    public float m = 0f;

    // Start is called before the first frame update
    void Start()
    {
        m = 0f;
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void FixedUpdate()
    {
        m+= Time.deltaTime;
        double i = 0.3*Mathf.Sin(m);

        RectTransform rectTransform = GetComponent<RectTransform>();
        rectTransform.Rotate(new Vector3(0, 0, Convert.ToSingle(i)));

    }
}
