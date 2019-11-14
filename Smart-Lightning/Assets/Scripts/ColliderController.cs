using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderController : MonoBehaviour
{

    public Light smartLight;

    void Start()
    {
        smartLight.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        smartLight.enabled = true;
    }

    private void OnTriggerStay(Collider other)
    {
        smartLight.enabled = true;
    }

    private void OnTriggerExit(Collider other)
    {
        Invoke("TurnLightOff", 10);
    }

    void TurnLightOff()
    {
        smartLight.enabled = false;
    }

}
