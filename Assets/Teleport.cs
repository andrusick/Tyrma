using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
   [SerializeField]
   protected Transform tp_2;

   [SerializeField]
   protected Vector3 offset;

   void OnTriggerEnter2D(Collider2D other)
   {
    if (other.TryGetComponent<PlayerEventManager>(out var playerEvent))
    {
        other.transform.position = tp_2.position + offset;
        playerEvent.Teleported();
    }
    
   }
}
