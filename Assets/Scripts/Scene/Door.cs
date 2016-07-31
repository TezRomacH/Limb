using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {

    private const byte angle = 10;
    enum estate { open, close};
    
    public bool isLeft;
    private estate state;
    private Quaternion tr;

    void Awake()
    {
        tr = transform.rotation;
    }

    void Start()
    {
        state = estate.close;
    }

    public void Open()
    {
        if (state == estate.open)
            return;

        if (isLeft)
        {
            StartCoroutine(Rotate(new Quaternion(tr.x, tr.y + angle, tr.z,tr.w)));
        }
        else
        {
            StartCoroutine(Rotate(new Quaternion(tr.x, tr.y - angle, tr.z, tr.w)));
        }

        state = estate.open;
    }

    public void Close()
    {
        if (state == estate.close)
            return;

        /*
         * 
         */

        state = estate.close;
    }

    IEnumerator Rotate(Quaternion r)
    {
        float time = 0;
        while (time < 1)
        {
            transform.rotation = Quaternion.Slerp(tr, r, time);
            yield return new WaitForFixedUpdate();
            time += Time.deltaTime / 150;
        }
    }
}
