using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class properties : MonoBehaviour
{

    public bool alive;
    public GameObject thisObj;
    public int xFlat;
    public int yFlat;
    public float initialZ = 30f;


    public void Start()
    {
        alive = true;
        thisObj = this.gameObject;
    }

    public void collision()
    {
        if (alive)
            {
            alive = false;
            thisObj.transform.localScale = new Vector3(xFlat, yFlat, initialZ);

            }
    }

}
