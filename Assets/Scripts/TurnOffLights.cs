using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffLights : MonoBehaviour 
{
    private Component[] lights;
    // Start is called before the first frame update
    void Start()
    {
        lights = GetComponentsInChildren<Light>();

        foreach (Light light in lights)
        {
            light.enabled = true;
            StartCoroutine(OnAndOff(light));
        }
    }
    public IEnumerator OnAndOff(Light light)
    {
        while (true)
        {
            yield return new WaitForSeconds(0.5f);
            Debug.Log("xd");
            //light.enabled = true;
            yield return new WaitForSeconds(0.5f);
            //light.enabled = false;
            light.color = Color.red;
        }
    }
    
    
}
