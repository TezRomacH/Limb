using UnityEngine;
using System.Collections;

public class SceneManager : MonoBehaviour {

    private Door door;
    private Door door1;

    void Awake()
    {
        if (GameObject.Find("DoorLeft"))
            door = GameObject.Find("DoorLeft").GetComponent<Door>();
        if (GameObject.Find("DoorRight"))
            door1 = GameObject.Find("DoorRight").GetComponent<Door>();
    }

    public void OpenDoors()
    {
        door.Open();
        door1.Open();
    }

    public void ToInfinite()
    {
        Application.LoadLevel(Id.toInfiniteScene);
    }
}
