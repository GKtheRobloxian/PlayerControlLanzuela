using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;

public class AnotherPlaneController : MonoBehaviour
{
    public Transform target;
    public float speed;
    Rigidbody rb;
    public GameObject projectile;
    float rotationOne;
    float rotationTwo;
    float rotationThree;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rotationOne = transform.rotation.x;
        rotationTwo = transform.rotation.y;
        rotationThree = transform.rotation.z;
        Vector3 rotationVector = new Vector3(rotationOne, rotationTwo, rotationThree);
        transform.LookAt(target);
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
