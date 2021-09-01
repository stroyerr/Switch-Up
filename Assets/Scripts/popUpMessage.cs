using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;

public class popUpMessage : MonoBehaviour
{
    //This is the game object to instantiate
    public Text popUpText;


    //This function will be called when a new popuptext is created
    public void newMessage(string message)
    {
        Text text = Instantiate(popUpText);
        text.text = message;
    }

}
