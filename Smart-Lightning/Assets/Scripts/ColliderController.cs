using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderController : MonoBehaviour
{

    public Light smartLight;
    public GameObject sphere;
    public Material LEDLightON;
    public Material LEDLightOFF;

    void Start()
    {
        TurnLightOff();
    }

    private void OnTriggerEnter(Collider other)
    {
        TurnLightON();
    }

    private void OnTriggerStay(Collider other)
    {
        TurnLightON();
    }

    private void OnTriggerExit(Collider other)
    {
        Invoke("TurnLightOff", 10);
    }

    private void TurnLightON()
    {
        smartLight.enabled = true;
        sphere.GetComponent<Renderer>().material = LEDLightON;
    }

    private void TurnLightOff()
    {
        smartLight.enabled = false;
        sphere.GetComponent<Renderer>().material = LEDLightOFF;
    }

}
