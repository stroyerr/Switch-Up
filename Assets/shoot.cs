using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public Rigidbody rb;
    private bool fire = false;
    public GameObject barrel;
    public GameObject bullet;
    public GameObject updater;
    GameObject clone;
    public float bulletSpeed = 30;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            fire = true;
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            fire = false;
        }
    }

    private void FixedUpdate()
    {
        if (fire)
        {
            Shoot();
        }
    }

    Vector3 bulletVelocity;


    public void Shoot()
    {
        if (updater.GetComponent<themeController>().theme == 3)
        {

            bulletVelocity.x = rb.velocity.x/Mathf.Abs(rb.velocity.x) * bulletSpeed;
            bulletVelocity.y = 0;
            bulletVelocity.z = 0;
            clone = (GameObject) Instantiate(bullet, barrel.transform.position, Quaternion.identity);
            Debug.Log(clone.GetComponent<Rigidbody>().velocity);
            clone.GetComponent<Rigidbody>().velocity = bulletVelocity;
            //Instantiate(bullet, barrel.transform.position, Quaternion.identity);
        }
      
    }
}
