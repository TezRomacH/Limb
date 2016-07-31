using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class button_continue : MonoBehaviour, IPointerDownHandler
{

    public bool flag_continue = false;

    public void OnPointerDown(PointerEventData eventData)
    {
        if (flag_continue)
        {
            Managers.ui.OnPlay();
        }
    }
	

}
