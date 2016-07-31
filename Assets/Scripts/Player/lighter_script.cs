using UnityEngine;
using System.Collections;

public class lighter_script : MonoBehaviour 
{
	public void LightOn()
    {
        gameObject.GetComponent<Light>().enabled = true;
    }

    public void LightOff()
    {
        gameObject.GetComponent<Light>().enabled = false;
    }
}
