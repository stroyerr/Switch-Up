using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class themeController : MonoBehaviour
{

    //0:Sunny
    //1:Fire
    //2:Neon
    //3:Space



    public Material mat0;
    public Material mat1;
    public Material mat2;
    public Material mat3;
    private int themeIndex = 0;
    private int newIndex = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            themeIndex = 0;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            themeIndex = 1;
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            themeIndex = 2;
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            themeIndex = 3;
        }

        Debug.Log(themeIndex);

        if (themeIndex != newIndex)
        {
            changeTheme();
        }


        newIndex = themeIndex;

    }

    private void changeTheme()
    {
        if (themeIndex == 0)
        {
            RenderSettings.skybox = mat0;
        }

        if (themeIndex == 1)
        {
            RenderSettings.skybox = mat1;
        }

        if (themeIndex == 2)
        {
            RenderSettings.skybox = mat2;
        }

        if (themeIndex == 3)
        {
            RenderSettings.skybox = mat3;
        }
    }
}
