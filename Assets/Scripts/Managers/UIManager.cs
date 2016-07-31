using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIManager : MonoBehaviour {

    public void OnStart()
    {
        GameObject.Find("Button_play").GetComponent<Image>().CrossFadeAlpha(0, 1f, true);
        GameObject.Find("Button_play").transform.GetChild(0).GetComponent<Text>().CrossFadeAlpha(0, 1f, true);
        GameObject.Find("Panel").GetComponent<Image>().CrossFadeAlpha(0, 1.5f, true);
        GameObject.Find("logo").GetComponent<Image>().CrossFadeAlpha(0, 1f, true);
        GameObject.Find("Button_play").GetComponent<RectTransform>().position = new Vector3(150000, 150000, 0);
        GameObject.Find("Button_door").GetComponent<Image>().CrossFadeAlpha(0.5f, 1f, true);
        GameObject.Find("Button_door").GetComponent<button_door>().flag_door = true; 
        Managers.game.OnStart();
    }

void BackToMainMenu()
    {
        GameObject.Find("Button_play").GetComponent<RectTransform>().position = GameObject.Find("Button_play").GetComponent<button_play>().pos;
        GameObject.Find("Button_play").transform.GetChild(0).GetComponent<Text>().CrossFadeAlpha(1f, 1f, true);
        GameObject.Find("Button_play").GetComponent<Image>().CrossFadeAlpha(1, 1f, true);
        GameObject.Find("logo").GetComponent<Image>().CrossFadeAlpha(1, 1f, true);
        GameObject.Find("Panel").GetComponent<Image>().CrossFadeAlpha(1, 1.5f, true);
    }

    public void OnPlay()
    {
        Debug.Log("OnPlay");
        GameObject.Find("Panel_pause").GetComponent<Image>().CrossFadeAlpha(0, 1f, true);
        GameObject.Find("Button_continue").GetComponent<Image>().CrossFadeAlpha(0, 1f, true);
        GameObject.Find("Button_exit").GetComponent<Image>().CrossFadeAlpha(0, 1f, true);
        GameObject.Find("Panel").GetComponent<Image>().CrossFadeAlpha(0, 1.5f, true);
        GameObject.Find("Button_door").GetComponent<Image>().CrossFadeAlpha(0.5f, 1f, true);


        GameObject.Find("Button_exit").GetComponent<button_exit>().flag_exit = false;
        GameObject.Find("Button_continue").GetComponent<button_continue>().flag_continue = false;
        GameObject.Find("Button_door").GetComponent<button_door>().flag_door = true; 

        Managers.game.OnPlay();
    }

    public void OnQuit()
    {
        Managers.game.OnQuit();
    }

    public void OnPause()
    {
        //GameObject.Find("Panel").GetComponent<Image>().CrossFadeAlpha(1, 1.5f, true);

        GameObject.Find("Button_door").GetComponent<Image>().CrossFadeAlpha(0, 1f, true);
        GameObject.Find("Button_door").GetComponent<button_door>().flag_door = false;

        GameObject.Find("Panel_pause").GetComponent<Image>().CrossFadeAlpha(0.8f, 1f, true);
        GameObject.Find("Button_continue").GetComponent<Image>().CrossFadeAlpha(1, 1f, true);
        GameObject.Find("Button_exit").GetComponent<Image>().CrossFadeAlpha(1, 1f, true);

        GameObject.Find("Button_exit").GetComponent<button_exit>().flag_exit = true;
        GameObject.Find("Button_continue").GetComponent<button_continue>().flag_continue = true;
        Managers.phone.OnPause();
Managers.game.OnPause();
    }

    public void OnPhoneOpen()
    {
        Managers.game.OnPhoneOpen();
    }

    public void OnPhoneClose()
    {
        Managers.game.OnPhoneClose();
    }
}
