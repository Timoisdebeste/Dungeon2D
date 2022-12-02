using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponRoatate : MonoBehaviour
{
    public static float turn;
    private float rotationX;

    // Update is called once per 50ms
    void FixedUpdate()
    {
        //rotationZ
        Vector2 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        difference.Normalize();
        float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;

        float rotationZP = Mathf.Abs(rotationZ);
        float rotationZN = -rotationZ;

        if (rotationZ <= -90)
        {
            rotationX = 180;
            transform.rotation = Quaternion.Euler(rotationX, 0f, rotationZP);
        }
        else if (rotationZ >= 90)
        {
            rotationX = 180;
            transform.rotation = Quaternion.Euler(rotationX, 0f, rotationZN);
        }
        else
        {
            rotationX = 0;
            transform.rotation = Quaternion.Euler(rotationX, 0f, rotationZ);
        }
    }
}
