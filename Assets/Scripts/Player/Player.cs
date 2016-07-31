using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.ThirdPerson;

public class Player : MonoBehaviour {
    
    [HideInInspector]
    public Transform bigItemPlace;
    
    private Animator anim;
    private AudioSource audio;
    private ThirdPersonCharacter chr3;
    private ThirdPersonUserControl control3;

    void Awake()
    {
        anim = GetComponent<Animator>();
        chr3 = GetComponent<ThirdPersonCharacter>();
        control3 = GetComponent<ThirdPersonUserControl>();
        audio = GetComponent<AudioSource>();
        bigItemPlace = transform.FindChild("BigItemPlace");
    }

    public void OnStart()
    {
    }

    void Update()
    {
        if (GetComponent<ThirdPersonUserControl>().isMoving)
            audio.enabled = true;
        else
        {
            audio.enabled = false;
        }
    }

    public void OnPlay()
    {
        GetComponent<Rigidbody>().isKinematic = false;

        anim.enabled = true;
        chr3.enabled = true;
        control3.enabled = true;
    }

    public void OnPause()
    {
        GetComponent<Rigidbody>().isKinematic = true;
        anim.enabled = false;        
        chr3.enabled = false;
        control3.enabled = false;
    }

    public void LightOn()
    {
        GetComponentInChildren<lighter_script>().LightOn();
    }

    public void LightOff()
    {
        GetComponentInChildren<lighter_script>().LightOff();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.name == Id.lighthouseOpenDoor)
            Managers.scene.OpenDoors();

        if (other.name == Id.infiniteTrigger)
            Managers.scene.ToInfinite();
    }
}
