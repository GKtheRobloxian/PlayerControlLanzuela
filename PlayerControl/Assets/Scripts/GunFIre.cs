using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFIre : MonoBehaviour
{
    float countdown = 10f;
    float InitialFireRate = 0.066f;
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
            rotationOne = transform.eulerAngles.x + Random.Range(-45.0f, 45.0f);
            Debug.Log(transform.eulerAngles.x + " " + rotationOne);
            rotationTwo = transform.eulerAngles.y + Random.Range(-45.0f, 45.0f);
            rotationThree = transform.eulerAngles.z + Random.Range(-45.0f, 45.0f);
            FireRate -= Time.deltaTime;
            if (FireRate <= 0)
            {
                Instantiate(projectile, rb.position, Quaternion.Euler(new Vector3(rotationOne, rotationTwo, rotationThree)));
                FireRate = InitialFireRate;
            }
        }
    }
}
