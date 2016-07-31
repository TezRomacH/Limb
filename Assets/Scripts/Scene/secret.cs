using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class secret : MonoBehaviour
{
    public List<Sprite> list;
    
	void Start () {
        GetComponent<SpriteRenderer>().sprite = list[0];
    }
	
	void Update ()
	{
	    if (Managers.camera.isPhoneCamera)
	        GetComponent<SpriteRenderer>().sprite = list[1];
	    else
	    {
            GetComponent<SpriteRenderer>().sprite = list[0];
        }

	}
}
