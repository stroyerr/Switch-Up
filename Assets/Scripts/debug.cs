using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class debug : MonoBehaviour
{

    public GameObject zone;
    private bool isZone = true;

    // Start is called before the first frame update
    void Start()
    {
        //popUpMessage message = popUpMessage.newMessage("test");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            isZone = !isZone;
        }
    }

    private void FixedUpdate()
    {
        if (isZone)
        {
            zone.SetActive(true);
        }
        else
        {
            zone.SetActive(false);
        }
    }
}
