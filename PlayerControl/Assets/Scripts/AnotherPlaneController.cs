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
    Gun gun;
    public float fireRate = 0.25f;
    float rotationOne;
    float rotationTwo;
    float rotationThree;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        gun = GetComponent<Gun>();
    }

    // Update is called once per frame
    void Update()
    {
        rotationOne = transform.rotation.x;
        rotationTwo = transform.rotation.y;
        rotationThree = transform.rotation.z;
        Vector3 rotationVector = new Vector3(rotationOne, rotationTwo, rotationThree);
        Vector3 extraRotation = new Vector3(0, -90, 90);
        fireRate -= Time.deltaTime;
        transform.LookAt(target);
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        if (fireRate < 0)
        {
            Instantiate(projectile, rb.position + Vector3.forward * 3.0f, Quaternion.Euler(rotationVector + extraRotation));
            fireRate = 0.25f;
        }
    }
}
