using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nukje : MonoBehaviour
{
    Rigidbody rb;
    GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        target = GameObject.FindGameObjectWithTag("Player");
        transform.LookAt(target.transform);
    }

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * 450f);
    }

    private void OnTriggerEnter(Collider other)
    {
        PlayerControllerX controller = other.GetComponent<PlayerControllerX>();

        if (controller != null)
        {
            controller.Damaged(3);
            Destroy(gameObject);
        }
    }
}
