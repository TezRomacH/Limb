using UnityEngine;
using System.Collections;

public class AudiosSounder : MonoBehaviour
{
    public int id;
    [HideInInspector()] public AudioClip clip;
    public bool needPlay = true;
    private AudioSource audio;

    void Start()
    {
        clip = Managers.audio.audios[id];
        audio = GetComponent<AudioSource>();
        audio.clip = clip;
        while (true)
            StartCoroutine(Play());
    }

    IEnumerator Play()
    {
        if (needPlay)
        {
            audio.Play();
            yield return new WaitForSeconds(audio.clip.length);
            audio.clip = clip;
            audio.Play();
        }
    }
}
