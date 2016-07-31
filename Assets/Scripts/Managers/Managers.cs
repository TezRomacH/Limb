using UnityEngine;
using System.Collections;

public class Managers : MonoBehaviour {

    private static AudioManager _audio;
    private static GameManager _game;
    private static UIManager _ui;
    private static InteractiveManager _i;
    private static PhoneManager _phone;
    private static Player _player;
    private static CameraManager _camera;
    private static ItemManager _item;
    private static SceneManager _scene;

    public static AudioManager audio
    {
        get
        {
            if (_audio == null)
            {
                _audio = GameObject.Find("Manager").GetComponent<AudioManager>();
            }

            return _audio;
        }
    }

    public static GameManager game
    {
        get
        {
            if (_game == null)
            {
                _game = GameObject.Find("Manager").GetComponent<GameManager>();
            }

            return _game;
        }
    }


    public static UIManager ui
    {
        get
        {
            if (_ui == null)
            {
                _ui = GameObject.Find("Manager").GetComponent<UIManager>();
            }

            return _ui;
        }
    }

    public static InteractiveManager inter
    {
        get
        {
            if (_i == null)
            {
                _i = GameObject.Find("Manager").GetComponent<InteractiveManager>();
            }

            return _i;
        }
    }

    public static PhoneManager phone
    {
        get
        {
            if (_phone == null)
            {
                _phone = GameObject.Find("Manager").GetComponent<PhoneManager>();
            }

            return _phone;
        }
    }

    public static Player player
    {
        get
        {
            if (_player == null)
            {
                _player = GameObject.Find("Player").GetComponent<Player>();
            }

            return _player;
        }
    }

    public static CameraManager camera
    {
        get
        {
            if (_camera == null)
            {
                _camera = GameObject.Find("Camera").GetComponent<CameraManager>();
            }

            return _camera;
        }
    }

    public static ItemManager item
    {
        get
        {
            if (_item == null)
            {
                _item = GameObject.Find("Manager").GetComponent<ItemManager>();
            }

            return _item;
        }
    }

    public static SceneManager scene
    {
        get
        {
            if (_scene == null)
            {
                _scene = GameObject.Find("Manager").GetComponent<SceneManager>();
            }

            return _scene;
        }
    }
}
