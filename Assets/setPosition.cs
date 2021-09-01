using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setPosition : MonoBehaviour
{

    public GameObject backgroundObject;
    public RectTransform imgTransform;
    public GameObject thisObject;
    private float quartile;

    public float x0 = 0f;
    private Vector3 position0;

    public static int theme = 0;
    private int currentTheme = 0;

    // Start is called before the first frame update
    void Start()
    {
        position0 = thisObject.transform.position;
        imgTransform = backgroundObject.GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!(currentTheme == theme))
        {
            setIndicator(theme);
            currentTheme = theme;
        }
        
    }

    public void setIndicator(int theme)
    {
        if(theme == 1)
        {
            thisObject.GetComponent<RectTransform>().anchoredPosition = new Vector3(-112.5f, -75, 0);
        }

        if(theme == 2)
        {
            thisObject.GetComponent<RectTransform>().anchoredPosition = new Vector3(-37.5f, -75, 0);
        }

        if(theme == 3)
        {
            thisObject.GetComponent<RectTransform>().anchoredPosition = new Vector3(37.5f, -75, 0);
        }

        if(theme == 4)
        {
            thisObject.GetComponent<RectTransform>().anchoredPosition = new Vector3(112.5f, -75, 0);
        }
    }

}
