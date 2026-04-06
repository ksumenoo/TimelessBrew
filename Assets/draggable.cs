using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class draggable : MonoBehaviour
{
    private Vector3 mOffset;
    private float mZCoord;
    public float rotationSpeed = 50f;
    void OnMouseDown()
    {
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        mOffset = gameObject.transform.position - GetMouseWorldPos();
    }
    private Vector3 GetMouseWorldPos()
    {
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = mZCoord;
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }
    void OnMouseDrag()
    {
        transform.position = GetMouseWorldPos() + mOffset;
        if (Input.GetKey(KeyCode.R))
        {
            transform.Rotate(Vector3.left * rotationSpeed * Time.deltaTime);
        }
        else
        {
            if (Input.GetKey(KeyCode.F))
            {
                transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
            }
        }
        if (Input.GetKey(KeyCode.Z))
        {
            transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        }
        else
        {
            if (Input.GetKey(KeyCode.X))
            {
                transform.Rotate(Vector3.down * rotationSpeed * Time.deltaTime);
            }
        }
        if (Input.GetKey(KeyCode.T))
        {
            transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
        }
        else
        {
            if (Input.GetKey(KeyCode.G))
            {
                transform.Rotate(Vector3.forward*-1 * rotationSpeed * Time.deltaTime);
            }
        }
    }
}