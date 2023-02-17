using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public GameObject CameraOne;
    public GameObject CameraTwo;
    int Camera = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("q"))
        {
            Camera = Camera * -1;
            if (Camera > 0)
            {
                CameraOne.SetActive(true);
                CameraTwo.SetActive(false);
            }
            else
            {
                CameraOne.SetActive(false);
                CameraTwo.SetActive(true);
            }
        }
    }
}
