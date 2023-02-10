using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset1 = Vector3.back * 18;
    private Vector3 offset2 = Vector3.up * 8;
    public float planeRotateSpeed;
    float horizontalInput;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = plane.transform.position + offset1 + offset2;
        transform.Rotate(Vector3.up, planeRotateSpeed*horizontalInput*Time.deltaTime);
    }
}
