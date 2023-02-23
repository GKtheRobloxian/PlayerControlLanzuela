using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tonk : MonoBehaviour
{
    float maxHealth = 10f;
    float countdown = 10f;
    public float speed = 8f;
    public float turnSpeed = 40f;
    float horizontalInput;
    float forwardInput;
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;
        if (countdown < 0)
        {
            transform.LookAt(target);
            horizontalInput = Input.GetAxis("Horizontal");
            forwardInput = Input.GetAxis("Vertical");
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);
        }
        if (maxHealth == 0)
        {
            Destroy(gameObject);
        }
    }
    
    public void Damaged(float integer)
    {
        maxHealth -= integer;
    }
}
