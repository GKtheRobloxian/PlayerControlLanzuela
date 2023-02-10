using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tonk : MonoBehaviour
{
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
        transform.LookAt(target);
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);
    }
}
