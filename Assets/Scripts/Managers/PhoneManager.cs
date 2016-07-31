using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PhoneManager : MonoBehaviour
{

    [HideInInspector()] public bool isOnCamera;

    public void OnStart()
    {
        isOnCamera = false;
        GameObject.Find("phone").GetComponent<RectTransform>().position = FindObjectOfType<button_phone>().pos_phone + new Vector3(0, -1000, 0);
    }

    public void OnPlay()
    {
        GameObject.Find("phone").GetComponent<RectTransform>().position = FindObjectOfType<button_phone>().pos_phone + new Vector3(0, 20, 0);
    }

    public void OnQuit()
    {
        GameObject.Find("phone").GetComponent<RectTransform>().position = FindObjectOfType<button_phone>().pos_phone + new Vector3(0, -1000, 0);
    }

    public void OnPause()
    {
        GameObject.Find("phone").GetComponent<RectTransform>().position = FindObjectOfType<button_phone>().pos_phone + new Vector3(0, -1000, 0);
    }

    public void OnPhoneOpen()
    {
        //GameObject.Find("phone").GetComponent<RectTransform>().position = FindObjectOfType<button_phone>().pos_phone + new Vector3(0, 20, 0);
    }

    public void OnPhoneClose()
    {
        //GameObject.Find("phone").GetComponent<RectTransform>().position = FindObjectOfType<button_phone>().pos_phone + new Vector3(0, -1000, 0);
    }

    public void CameraEnable()
    {
        Managers.game.OnCameraEnable();
    }

    public void CameraDisable()
    {
        Managers.game.OnCameraDisable();
    }
}
