using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Rigidbody rb;
    float MaxLifetime = 5f;
    public GameObject planeUsing;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        MaxLifetime -= Time.deltaTime;
        PlayerControllerX controller = other.GetComponent<PlayerControllerX>();

        if (controller != null)
        {
            controller.Damaged();
            Destroy(gameObject);
        }
        if (MaxLifetime == 0)
        {
            Destroy(gameObject);
        }
    }
}
