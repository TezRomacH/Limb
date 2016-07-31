using UnityEngine;
using System.Collections;

public class InfiniteBlock : MonoBehaviour {

    private InfiniteManager mng;
    public Transform[] wallPlace;
    public Transform[] tumbochkaPlace;
    public Transform[] koverPlace;

    void Awake()
    {
        mng = GameObject.Find("Manager").GetComponent<InfiniteManager>();
    }

	void Start () {
        foreach (Transform place in wallPlace)
        {
            if (Random.Range(0, 7) == 1)
                continue;

            Instantiate(mng.walls[Random.Range(0, mng.walls.Length)], place.position, place.rotation);
        }

        foreach (Transform place in tumbochkaPlace)
        {
            if (Random.Range(0, 4) == 1)
                continue;

            Instantiate(mng.tumbochkas[Random.Range(0, mng.tumbochkas.Length)], place.position, place.rotation);
        }
	}
}
