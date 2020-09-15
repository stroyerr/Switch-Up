using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{

    public GameObject player;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            reloadLevel();
        }

        if (player.transform.position.y < -10)
        {
            reloadLevel();
        }

     
    }

    public void reloadLevel()
    {
        Application.LoadLevel(Application.loadedLevel);
    }

    
}
