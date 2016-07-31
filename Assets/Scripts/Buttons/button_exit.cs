using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class button_exit : MonoBehaviour, IPointerDownHandler
{

    public bool flag_exit = false;

    public void OnPointerDown(PointerEventData eventData)
    {
        if (flag_exit)
        {
            Managers.ui.OnQuit();
        }
    }
	

}
