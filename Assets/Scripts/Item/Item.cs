using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour {
    public byte level;
    public byte id;
    public bool isAssignt;

    public void BigItemActivate()
    {
        Destroy(GetComponent<Rigidbody>());
        transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
        isAssignt = true;
    }
}
