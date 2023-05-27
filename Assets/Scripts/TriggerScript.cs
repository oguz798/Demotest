using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    public GameObject lights;

    void OnTriggerEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            lights.GetComponent<TurnOffLights>().enabled = true;
        }
    }


}