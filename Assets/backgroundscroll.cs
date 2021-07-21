using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundscroll : MonoBehaviour
{
    private float m = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        m += Time.deltaTime;
        float i = 1000*Mathf.Sin(m/10) - 430;
        RectTransform rect = GetComponent<RectTransform>();
        rect.localPosition = new Vector3(i, -17, 0);
    }
}
