using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    public GameObject lights;

    private void Start()
    {
        lights.GetComponent<TurnOffLights>().enabled = false;
    }

    void OnTriggerEnter(Collision other)
    {

        lights.GetComponent<TurnOffLights>().enabled = true;

    }


}