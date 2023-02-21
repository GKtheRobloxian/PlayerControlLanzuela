using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objective : MonoBehaviour
{
    public Transform plane;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, plane.transform.position) < 100)
        {
            transform.position = new Vector3(Random.Range(100, 5000), Random.Range(100, 5000), Random.Range(100, 5000));
        }
    }
}
