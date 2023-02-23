using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public GameObject CameraOne;
    public GameObject CameraTwo;
    public GameObject CameraThree;
    public GameObject CameraFour;
    public int Remainder;
    public int Camera = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("q"))
        {
            Camera = Camera + 1;
            Remainder = Camera % 4;
            if (Remainder == 1)
            {
                CameraOne.SetActive(true);
                CameraTwo.SetActive(false);
                CameraThree.SetActive(false);
                CameraFour.SetActive(false);
            }
            else
            {
                if (Remainder == 2)
                {
                    CameraOne.SetActive(false);
                    CameraTwo.SetActive(true);
                    CameraThree.SetActive(false);
                    CameraFour.SetActive(false);
                }
                else
                {
                    if (Remainder == 3)
                    {
                        CameraOne.SetActive(false);
                        CameraTwo.SetActive(false);
                        CameraThree.SetActive(true);
                        CameraFour.SetActive(false);
                    }
                    else
                    {
                        if (Remainder == 0)
                        {
                            CameraOne.SetActive(false);
                            CameraTwo.SetActive(false);
                            CameraThree.SetActive(false);
                            CameraFour.SetActive(true);
                        }
                    }
                }
            }
        }
    }
}
