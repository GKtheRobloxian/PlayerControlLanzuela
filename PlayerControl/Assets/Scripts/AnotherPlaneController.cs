using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;

public class AnotherPlaneController : MonoBehaviour
{
    float maxHealth = 5f;
    float countdown = 10f;
    public Transform target;
    public float speed;
    Rigidbody rb;
    public GameObject projectile;
    float rotationOne;
    float rotationTwo;
    float rotationThree;
    public GameObject self;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
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
            Vector3 rotationVector = new Vector3(rotationOne, rotationTwo, rotationThree);
            self.transform.rotation = Quaternion.Slerp(Quaternion.Euler(transform.localEulerAngles), Quaternion.Euler(transform.TransformDirection(target.transform.position - transform.position)), 225 * Time.deltaTime);
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
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
