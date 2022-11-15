using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    float rotationspeed = 1f;

    void OnMouseDrag()
    {
        float XaxisRotation = Input.GetAxis("Mouse X") * rotationspeed;
        float YaxisRotation = Input.GetAxis("Mouse Y") * rotationspeed;
        transform.Rotate(Vector3.down, XaxisRotation);
        transform.Rotate(Vector3.right, YaxisRotation);
    }
}
