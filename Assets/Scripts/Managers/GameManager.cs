using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public static byte levelCount;

    public void OnStart()
    {
        Managers.inter.OnStart();
        Managers.player.OnStart();
    }

    public void OnPlay()
    {
        Managers.inter.OnPlay();
        Managers.player.OnPlay();
    }

    public void OnQuit()
    {
        Managers.inter.OnQuit();
    }

    public void OnPause()
    {
        Managers.inter.OnPause();
        Managers.player.OnPause();
    }

    public void OnPhoneOpen()
    {
        Managers.phone.OnPhoneOpen();
    }

    public void OnPhoneClose()
    {
        Managers.phone.OnPhoneClose();
    }

    public void OnCameraEnable()
    {

    }

    public void OnCameraDisable()
    {

    }

public void OnItemSelected()
    {
        Managers.player.OnPause();
    }

    public void OnItemDeselected()
    {

    }
}
