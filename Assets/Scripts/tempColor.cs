using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tempColor : MonoBehaviour
{

    public GameObject temp;

    public GameObject thisObject;
     
    private static Vector2 originalPos;
    public float originalX;
    public static float originalY;
    public static float temperatureFloat;
    private static float widthOfImage;
    public GameObject imagePrior;
    private static float movementRatio;
    public float adjustment = 1f;

    public float differenceFrom0 = 0f;

    // Start is called before the first frame update
    void Start()
    {
        originalPos = thisObject.transform.position;
        originalX = thisObject.transform.position.x;
        originalY = thisObject.transform.position.y;
        widthOfImage = imagePrior.GetComponent<RectTransform>().rect.width;
        float movementRatio = widthOfImage / 200;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("finding temp...");
        temperatureFloat = temp.GetComponent<temperature>().temp;
        Debug.Log("New temp " + temperatureFloat);
        updatePosition();
        

    }

    public void updatePosition()
    {
        thisObject.GetComponent<RectTransform>().position = new Vector2((originalX + temperatureFloat * adjustment), originalY);
    }
}
