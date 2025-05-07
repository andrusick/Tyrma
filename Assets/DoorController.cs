using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour,Iinteractable
{
    [SerializeField]
    protected Animator animator;

    protected bool isOpen = false;

    protected virtual void Start()
    {
        animator = GetComponent<Animator>();
    }
    public void Interact()
    {
        if (isOpen)
        {
            isOpen = false;
            animator.SetBool("DoorisOpen ", isOpen);

        }
        else 
        {
            isOpen = true;
            animator.SetBool("DoorisOpen ", isOpen);
        }
    }
   
}
