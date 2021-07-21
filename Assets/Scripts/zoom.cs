using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zoom : MonoBehaviour
{

    public int zoomType = 0;
    private bool isDown = false;

    //0: Camera Follow
    //1: Manual (less zoom)
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            isDown = true;
            toggleZoom();
        }else if (Input.GetKeyUp(KeyCode.Z))
        {
            isDown = false;
        }
    }

    void toggleZoom()
    {
        bool newDown = false;

    if (isDown != newDown)
    {

        
        if (zoomType == 0)
        {
            zoomType = 1;
        }
        else
        {
            zoomType = 0;
        }

            newDown = isDown;
    }
    }
}
