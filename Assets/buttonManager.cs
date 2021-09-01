using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startGame()
    {
        int next = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(next);
        Debug.Log("loading scene " + next);
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
