using UnityEngine;
using System.Collections;

public class InfiniteManager : MonoBehaviour {

    public GameObject[] tumbochkas;
    public GameObject[] walls;
    public GameObject[] kovers;

    public GameObject backWall;
    public GameObject block;
    private GameObject lastBlock;
    private float length = -10;
    private float backWallLength = -10;
    private byte startBlocksCount = 5;
    private GameObject g_backWall;

    void Start()
    {
        g_backWall = (GameObject)Instantiate(backWall, new Vector3(0, 0, -10), Quaternion.Euler(new Vector3 (90,0,0)));
        for (int i = 0; i < startBlocksCount; i++)
        {
            CreateBlock(true);
        }

        InvokeRepeating("Check", 0, 1);
    }

    GameObject GetBlock()
    {
        if (GameManager.levelCount == 1)
            return block;

        return block;
    }

    void Check()
    {
        if (Vector3.Distance(Managers.player.transform.position, lastBlock.transform.position) < 30)
        {
            CreateBlock(false);
        }
    }

    void CreateBlock(bool isStart)
    {
        GameObject t = (GameObject)Instantiate(GetBlock(), new Vector3(0,0, length), Quaternion.identity);
        lastBlock = t;
        Vector3 p = g_backWall.transform.position;

        if (!isStart)
        {
            g_backWall.transform.position = new Vector3(p.x, p.y, backWallLength);
            backWallLength += 11.9f;
        }

        length += 11.9f;
    }
}
