using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class launcha : MonoBehaviour
{
    Rigidbody rb;
    GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        target = GameObject.FindGameObjectWithTag("Enemy");
        transform.LookAt(target.transform);
    }

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * 450f);
    }

    private void OnTriggerEnter(Collider other)
    {
        AnotherPlaneController controller = other.GetComponent<AnotherPlaneController>();
        Tonk controller2 = other.GetComponent<Tonk>();

        if (controller != null)
        {
            controller.Damaged(1);
            Destroy(gameObject);
        }
        else
        {
            if(controller2 != null)
            {
                controller2.Damaged(1);
                Destroy(gameObject);
            }
        }
    }
}
