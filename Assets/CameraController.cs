using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    protected PlayerEventManager playerEventManager;

    protected virtual void Start()
    {
        playerEventManager.OnTeleported += MoveCamera;
    }
    protected virtual void MoveCamera()
    {

    }
}
