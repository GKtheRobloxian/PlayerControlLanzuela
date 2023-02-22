using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float verticalInput;
    public float horizontalInput;
    public float planeRotateSpeed;
    public float planeSpinSpeed;
    Rigidbody rb;
    public float Health = 5;
    float XPosition;
    float YPosition;
    float ZPosition;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = new Vector3(XPosition, YPosition, ZPosition);
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * Time.deltaTime*speed);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right, rotationSpeed*verticalInput * Time.deltaTime);
        transform.Rotate(Vector3.up, planeRotateSpeed * horizontalInput * Time.deltaTime);
        transform.Rotate(Vector3.forward, planeSpinSpeed * horizontalInput * Time.deltaTime*-1);

        if (Health <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void Damaged(float integer)
    {
        Health -= integer;
    }
}
