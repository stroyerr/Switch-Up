using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class uiController : MonoBehaviour
{
    public Text txt;
    public GameObject player;
    public GameObject temp;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        txt.text = "Velocity: " + player.GetComponent<Rigidbody>().velocity + " & Position " + player.transform.position + " & Temperature = " + temp.GetComponent<temperature>().temp + ". Current entities: " +  GameObject.FindGameObjectsWithTag("bullet").Length;
    }
}
