using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    float countdown = 10f;
    float InitialFireRate = 20f;
    float FireRate;
    public GameObject projectile;
    Rigidbody rb;
    float rotationOne;
    float rotationTwo;
    float rotationThree;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        FireRate = InitialFireRate;
    }

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;
        if (countdown < 0)
        {
            rotationOne = transform.rotation.x;
            rotationTwo = transform.rotation.y;
            rotationThree = transform.rotation.z;
            FireRate -= Time.deltaTime;
            if (FireRate <= 0)
            {
                if(Input.GetKeyDown("e"))
                {
                    Instantiate(projectile, rb.position, Quaternion.Euler(new Vector3(rotationOne, rotationTwo, rotationThree)));
                    FireRate = InitialFireRate;
                }
            }
        }
    }
}
