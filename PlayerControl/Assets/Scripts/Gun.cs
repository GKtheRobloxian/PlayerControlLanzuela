using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Gun : MonoBehaviour
{
    Rigidbody rb;
    float MaxLifetime = 1.5f;
    public Transform position;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        transform.LookAt(position);
        transform.Translate(Vector3.forward * 792.48f*Time.deltaTime);
        MaxLifetime -= Time.deltaTime;
        if (MaxLifetime < 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        PlayerControllerX controller = other.GetComponent<PlayerControllerX>();

        if (controller != null)
        {
            controller.Damaged();
            Destroy(gameObject);
        }
    }
}
