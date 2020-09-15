using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class show : MonoBehaviour
{
    public CanvasGroup canvasGroup;

    // Start is called before the first frame update
    void Start()
    {
        Hide();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   
    public void Hide()
    {
        transform.localScale=new Vector3(0,0,0);
    }


    public void Show()
    {
        transform.localScale = new Vector3(1, 1, 1);
    }
}
