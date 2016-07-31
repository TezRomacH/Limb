using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class button_play : MonoBehaviour, IPointerDownHandler, IPointerEnterHandler
{
    public Vector3 pos;

    void Start()
    {
        pos = GetComponent<RectTransform>().position;
        GameObject.Find("Panel_pause").GetComponent<Image>().CrossFadeAlpha(0, 0f, true);
        GameObject.Find("Button_continue").GetComponent<Image>().CrossFadeAlpha(0, 0f, true);
        GameObject.Find("Button_exit").GetComponent<Image>().CrossFadeAlpha(0, 0f, true);
    }

	public void OnPointerDown(PointerEventData eventData)
    {
        Managers.ui.OnStart();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {

    }
}