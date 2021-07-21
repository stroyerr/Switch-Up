using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class themeController : MonoBehaviour
{

    //0:Sunny
    //1:Neon
    //2:Space
    //3:Fire


    public Material mat0;
    public Material mat1;
    public Material mat2;
    public Material mat3;
    public Material mat4;
    public int theme = 0;
    private int newIndex = 1;
    public GameObject player;
    public Material p0;
    public Material p1;
    public Material p2;
    public Material p3;
    public Material p4;
    public GameObject UI;
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            theme = 0;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            theme = 1;
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            theme = 2;
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            theme = 3;
        }
    }

    private void FixedUpdate()
    {

        

        if (theme != newIndex)
        {
            changeTheme();
        }


        newIndex = theme;

    }

    private void changeTheme()
    {
        if (theme == 0)
        {
            RenderSettings.skybox = mat0;
            player.GetComponent<MeshRenderer>().material = p0;
            UI.GetComponent<show>().Hide();
        }

        if (theme == 1)
        {
            RenderSettings.skybox = mat1;
            player.GetComponent<MeshRenderer>().material = p1;
            UI.GetComponent<show>().Hide();
        }

        if (theme == 2)
        {
            RenderSettings.skybox = mat2;
            player.GetComponent<MeshRenderer>().material = p2;
            UI.GetComponent<show>().Hide();
        }

        if (theme == 3)
        {
            RenderSettings.skybox = mat3;
            player.GetComponent<MeshRenderer>().material = p3;
            UI.GetComponent<show>().Show();
        }

        if (theme == 4)
        {
            RenderSettings.skybox = mat3;
            player.GetComponent<MeshRenderer>().material = p3;
            UI.GetComponent<show>().Show();
        }
    }

    public void setTheme(int theme)
    {
        if (theme == 4)
        {
            RenderSettings.skybox = mat4;
           // player.GetComponent<MeshRenderer>().material = p4;
            UI.GetComponent<show>().Show();
        }
    }
}
