using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class button_door : MonoBehaviour, IPointerDownHandler
{

    public bool flag_door = false;
    
	void Start () 
    {
        GameObject.Find("Button_door").GetComponent<Image>().CrossFadeAlpha(0, 0f, true);
	}

    public void OnPointerDown(PointerEventData eventData)
    {
        if (flag_door)
        {
            Managers.ui.OnPause();
        }
    }

}
