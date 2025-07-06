using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraStateChanger : MonoBehaviour
{
    [SerializeField]

    protected CameraController cameraController;

    [SerializeField]
    protected CameraState stateToChange;

    [SerializeField]
    protected Vector3 targetPoint;
    protected virtual void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (stateToChange == CameraState.MoveToPoint)
            {
                cameraController.SetTargetPoint(targetPoint, false);
            }
            else
            {
                cameraController.ReturnToPlayer();
            }
        }
    }
}
