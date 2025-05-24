using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerEventManager : MonoBehaviour
{

  public event Action OnTeleported = delegate {};

  public void Teleported()
  {
    OnTeleported?.Invoke();
  }
}
