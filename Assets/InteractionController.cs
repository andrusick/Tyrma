using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionController : PlayerController
{
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(Input.GetKeyDown(KeyCode.E) && isMove == true)
            {
                if (collision.gameObject.TryGetComponent<Iinteractable>(out var interactible))
                    {
                        interactible.Interact();
                    }
            }
         if(Input.GetKeyDown(KeyCode.E) && isMove == false)
            {
                if (collision.gameObject.TryGetComponent<Iinteractable>(out var interactible))
                    {
                        interactible.Interact_1();
                    }
            }
    }
}
