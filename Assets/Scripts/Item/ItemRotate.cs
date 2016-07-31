using UnityEngine;
using System.Collections;

public class ItemRotate : MonoBehaviour
{
    private Item item;

    private Quaternion originRotation;
    private Vector3 screenPoint;
    private float angleX = 0.0f;
    private float angleY = 0.0f;
    private float sensitivity = 6.0f;
    private float speed = 50.0f;

    void Start()
    {
        originRotation = transform.rotation;
        screenPoint = Camera.main.WorldToScreenPoint(transform.position);
        item = GetComponent<Item>();
    }

    void Update()
    {
        if (item.isAssignt)
        {
            if (angleX > 359.9f) angleX = 0;
            if (angleX < 0) angleX = 359.9f;

            if (angleY > 359.9f) angleY = 0;
            if (angleX < 0) angleX = 359.9f;

            Quaternion rotate = originRotation*Quaternion.AngleAxis(angleX, Vector3.up)*
                                Quaternion.AngleAxis(angleY, Vector3.left);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotate, Time.deltaTime*speed);
        }
    }

    void OnMouseDrag()
    {
        if (item.isAssignt)
        {
            float directionX = 0f;
            float directionY = 0f;
            float directionZ = 0f;

            if (Input.mousePosition.x > screenPoint.x && Input.mousePosition.y > screenPoint.y)
            {
                directionX = 1f;
                directionY = -1f;
            }
            else if (Input.mousePosition.x < screenPoint.x && Input.mousePosition.y < screenPoint.y)
            {
                directionX = -1f;
                directionY = 1f;
            }
            else if (Input.mousePosition.x < screenPoint.x && Input.mousePosition.y > screenPoint.y)
            {
                directionX = 1f;
                directionY = 1f;
            }
            else if (Input.mousePosition.x > screenPoint.x && Input.mousePosition.y < screenPoint.y)
            {
                directionX = -1f;
                directionY = -1f;
            }

            angleX += Input.GetAxis("Mouse X")*sensitivity*directionX;
            angleY += Input.GetAxis("Mouse Y")*sensitivity*directionY;
        }
    }
}
