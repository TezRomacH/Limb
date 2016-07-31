using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class button_light : MonoBehaviour, IPointerDownHandler
{
    public bool flag_light = false;

    public void OnPointerDown(PointerEventData eventData)
    {
        if (!flag_light)
        {
            FindObjectOfType<Player>().LightOn();
            flag_light = !flag_light;
        }
        else
        {
            FindObjectOfType<Player>().LightOff();
            flag_light = !flag_light;
        }
        
    }
}
