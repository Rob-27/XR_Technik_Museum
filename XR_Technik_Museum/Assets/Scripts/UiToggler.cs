using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiToggler : MonoBehaviour
{
    public GameObject museumInformation;

    public GameObject museumLocation;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void toggleInformation()
    {
        museumLocation.SetActive(false);

        if (museumInformation.activeSelf == true)
        {
            museumInformation.SetActive(false);

        }

        else if (museumInformation.activeSelf == false)
        {
            museumInformation.SetActive(true);

        }
    }

    public void toggleLocation()
    {
        museumInformation.SetActive(false);

        if (museumLocation.activeSelf == true)
        {
            museumLocation.SetActive(false);

        }

        else if (museumLocation.activeSelf == false)
        {
            museumLocation.SetActive(true);

        }
    }

}
