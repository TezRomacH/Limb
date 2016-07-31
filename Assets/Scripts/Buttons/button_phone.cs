using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class button_phone : MonoBehaviour, IPointerDownHandler
{
    public bool flag_active_phone = false;
    public Vector3 pos_phone;

    void Start()
    {
        pos_phone = GetComponent<RectTransform>().position;
        Managers.phone.OnStart(); 
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (!flag_active_phone)
            {
                Managers.phone.OnPlay();
            }
            else
            {
                Managers.phone.OnQuit();
            }
            FindObjectOfType<button_light>().flag_light = !FindObjectOfType<button_light>().flag_light;
            FindObjectOfType<button_camera>().flag_camera = !FindObjectOfType<button_camera>().flag_camera;
            flag_active_phone = !flag_active_phone;
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (!flag_active_phone)
            {
                Managers.phone.OnPlay();
            }
            else
            {
                Managers.phone.OnQuit();
            }
            FindObjectOfType<button_light>().flag_light = !FindObjectOfType<button_light>().flag_light;
            FindObjectOfType<button_camera>().flag_camera = !FindObjectOfType<button_camera>().flag_camera;
            flag_active_phone = !flag_active_phone;
        }
    }
}
