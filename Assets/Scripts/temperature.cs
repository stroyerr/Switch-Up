using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class temperature : MonoBehaviour
{
    public float spaceTemp = -100;
    public float fireTemp = 100;
    public float temp = 0;
    private int theme;
    public float rate = 0.3f;
    public GameObject updater;
    public float recoverRate = 5f;
    public Text indicator;
    public GameObject ind;
    public Vector3 initial;
    private float indHeight = 0f;

    // Update is called once per frame
    void Update()
    {
        theme = updater.GetComponent<themeController>().theme;

        //Display via indicator

        //Debug.Log(indHeight);
    }

    private void FixedUpdate()
    {
        //Debug.Log(temp);

        if (theme == 3)
        {
            if (temp < 100)
            {
                temp += fireTemp * rate / 100;
            }
            else
            {
                updater.GetComponent<themeController>().theme = 0;
            }
        }

        if (theme == 2)
        {
            if (temp > -100)
            {
                temp += spaceTemp * rate / 100;
            }
            else
            {
                //Debug.Log("Too Cold");
                updater.GetComponent<themeController>().theme = 0;
            }
        }

        if (theme != 2 && theme != 3)
        {
            if (temp < 0)
            {
                temp += recoverRate;
            }else if (temp > 0)
            {
                temp -= recoverRate;
            }
        }
    }

}
