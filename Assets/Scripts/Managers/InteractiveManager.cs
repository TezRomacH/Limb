using UnityEngine;
using System.Collections;

public class InteractiveManager : MonoBehaviour
{

    public Transform player;

    [Range(0f, 20f)]
    public float MaxDistance;

    [HideInInspector()]
    public bool hasItem;

    private Camera cam;
    private GameObject bigItem;

    void Awake()
    {
        cam = Managers.camera.GetComponent<Camera>();
    }

    void Start()
    {
        hasItem = false;
    }

    void Update()
    {
        if (!hasItem)
        {
            if (Input.GetMouseButton(0))
            {
                RaycastHit hit;
                Ray ray = cam.ScreenPointToRay(Input.mousePosition);

                if (Physics.Raycast(ray, out hit) && (hit.collider.tag == "Item"))
                {
                    if (Vector3.Distance(cam.transform.position, hit.transform.position) > MaxDistance)
                        return;

                    bigItem = CreateBigItem(hit.transform.gameObject.GetComponent<Item>());
                    OnPause();
                }
            }
        }
        else
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                hasItem = false;
                Managers.camera.DepthEnable(false);
                DestroyBigItem(bigItem);
                OnPlay();
            }
        }
    }

    GameObject CreateBigItem(Item item)
    {
        hasItem = true;

        Managers.player.OnPause();

        byte id = item.id;
        GameObject itemModel = Managers.item.ItemById(id);

        GameObject t_bigItem = Instantiate(itemModel, Managers.player.bigItemPlace.position, Quaternion.identity) as GameObject;
        t_bigItem.GetComponent<Item>().BigItemActivate();
        Managers.camera.DepthEnable(true);
        return t_bigItem;
    }

    void DestroyBigItem(GameObject item)
    {
        Managers.player.OnPlay();
        Destroy(item);
    }

    public void OnStart()
    {

    }

    public void OnQuit()
    {

    }

    public void OnPlay()
    { 
        Managers.player.OnPlay();
    }

    public void OnPause()
    {
        Managers.player.OnPause();
    }
}
