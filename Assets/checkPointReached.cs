using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class checkPointReached : MonoBehaviour{

    public GameObject thisObject;
    private Vector3 hidePosition = new Vector3(0, 10000, 0);
    private static bool notify = false;
    private static float timePassed = 0f;

    public static void notifyUser()
    {
        notify = true;
        timePassed = 0f;
    }

    public void Update()
    {

        if(timePassed < 5 && notify)
        {
            Debug.Log("time passed " + timePassed);
            timePassed += Time.deltaTime;
            float newY;
            newY = 90*Mathf.Sin(timePassed * 2);
            thisObject.transform.position = new Vector3(0, newY + 500, 0);
        }else if(timePassed >= 5 && notify)
        {
            Debug.Log("resetting");
            thisObject.transform.position = new Vector3(0, 10000, 0);
            timePassed = 0f;
            notify = false;
        }
        else
        {
            thisObject.transform.position = new Vector3(0, 10000, 0);
        }

    }

}
