using UnityEngine;
using System.Collections;
using UnityStandardAssets.ImageEffects; 

public class CameraManager : MonoBehaviour {

    private Player player;
    private DepthOfField depth;

    [HideInInspector()] public bool isPhoneCamera;

    void Awake()
    {
        depth = GetComponent<DepthOfField>();
        player = Managers.player;
    }

    void Start()
    {
        isPhoneCamera = false;
    }

    void Update()
    {

    }

    public void OnStart()
    {

    }

    public void OnPlay()
    {

    }

    public void OnPause()
    {

    }

    public void DepthEnable(bool enable) {
        depth.enabled = enable;    
    }
}
