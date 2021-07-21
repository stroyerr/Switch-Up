using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameOver : MonoBehaviour
{

    public Canvas menu;
    private bool isShowing = false;

    // Start is called before the first frame update
    void Start()
    {
        menu.scaleFactor = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Timescale "+Time.timeScale); 
    }

    public void end()
    {
        isShowing = true;
        menu.scaleFactor = 1.25f;
        Time.timeScale = 0;
    }

    public void begin()
    {
        Time.timeScale = 1;
    }
}
