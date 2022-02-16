using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    public Transform Target;

    public float smoothSpeed;

    public Vector3 offset;
    void LateUpdate()
    {
        Vector3 desiredPosition = Target.position + offset;

        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        transform.position = smoothedPosition;

    }
}
