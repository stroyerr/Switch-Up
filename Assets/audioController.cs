using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioController : MonoBehaviour
{

    public AudioSource jump;
    public AudioSource death;
    public AudioSource checkpoint;
    public AudioSource switchAbility;
    public AudioSource complete;
    public AudioSource bullet;

    public static bool jumpTrue = false;
    public static bool deathTrue = false;
    public static bool checkpointTrue = false;
    public static bool switchTrue = false; 
    public static bool completeTrue = false;
    public static bool bulletTrue = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (jumpTrue)
        {
            jumpSound();
            jumpTrue = false;
        }
        if (deathTrue)
        {
            deathSound();
            deathTrue = false;
        }
        if (checkpointTrue)
        {
            checkPointSound();
            checkpointTrue = false;
        }
        if (switchTrue)
        {
            switchSound();
            switchTrue = false;
        }
        if (completeTrue)
        {
            completeSound();
            completeTrue = false;
        }
        if (bulletTrue)
        {
            bulletSound();
            bulletTrue = false;
        }
    }

    public void bulletSound()
    {
        bullet.Play();
    }

    public void jumpSound()
    {
        jump.Play();
    }

    public void deathSound()
    {
        death.Play();
    }

    public void checkPointSound()
    {
        checkpoint.Play();
    }

    public void switchSound()
    {
        switchAbility.Play();
    }

    public void completeSound()
    {
        complete.Play();
    }

}
