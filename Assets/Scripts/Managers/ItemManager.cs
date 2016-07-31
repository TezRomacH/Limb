using UnityEngine;
using System.Collections;

public class ItemManager : MonoBehaviour {

    public GameObject[] items;

    public void OnStart()
    {

    }

    public void OnPlay()
    {

    }

    public void OnPause()
    {

    }

    public GameObject ItemById(byte id)
    {
        return items[id];
    }

    public GameObject[] ItemsByLevel(byte level)
    {
        ArrayList t = new ArrayList();

        foreach (GameObject item in items)
        {
            if (item.GetComponent<Item>().level == level)
                t.Add(item);
        }

        GameObject[] _t = new GameObject[t.Count];

        for (int i = 0; i < t.Count; i++)
            _t[i] = (GameObject)t[i];

        return _t;
    }

}
