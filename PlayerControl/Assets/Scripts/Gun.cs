using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Gun : MonoBehaviour
{
    Rigidbody rb;
    GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        target = GameObject.FindGameObjectWithTag("Player");
        transform.LookAt(target.transform);
        transform.eulerAngles = transform.eulerAngles + Vector3.right * Random.Range(-15.0f, 15.0f) + Vector3.up * Random.Range(-15.0f, 15.0f) + Vector3.forward * (Random.Range(-15.0f, 15.0f));
    }

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * 762.48f);
    }

    private void OnTriggerEnter(Collider other)
    {
        PlayerControllerX controller = other.GetComponent<PlayerControllerX>();

        if (controller != null)
        {
            controller.Damaged(1);
            Destroy(gameObject);
        }
    }
}
