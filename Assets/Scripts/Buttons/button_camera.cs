using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class button_camera : MonoBehaviour, IPointerDownHandler
{
    public Transform phone;

    void Start()
    {
        phone.localScale = new Vector3(0.1f, 0.1f, 0.1f);
    }

    public bool flag_camera = false;

    public void OnPointerDown(PointerEventData eventData)
    {
        if (flag_camera)
        {
            OnCameraEnter();
        }
        else
        {
            OnCameraExit();
        }
    }

    void Update()
    {
        if (Managers.phone.isOnCamera && (Input.GetKey(KeyCode.Escape) || Input.GetKey(KeyCode.Q)))
        {
            OnCameraExit();
        }
    }

    public void OnCameraEnter()
    {
        Managers.phone.isOnCamera = true;
        Managers.phone.OnQuit();
        FindObjectOfType<button_phone>().flag_active_phone = false;
        Managers.camera.isPhoneCamera = true;
        Managers.camera.transform.localPosition = new Vector3(0.3f, 1.4f, 0f);

        phone.parent = Managers.camera.transform;
        phone.localPosition = new Vector3(0f, 0f, 2f);
        phone.localRotation = new Quaternion(0f, 0f, 0f, 0f);
    }

    public void OnCameraExit()
    {
        Managers.phone.isOnCamera = false;
        Managers.phone.OnPlay();
        FindObjectOfType<button_phone>().flag_active_phone = true;
        Managers.camera.isPhoneCamera = false;
        Managers.camera.transform.localPosition = new Vector3(0.3f, 1.4f, -0.75f);

        phone.parent = null;
        phone.position = new Vector3(-150000f, -150000f, 0f);
    }
}
