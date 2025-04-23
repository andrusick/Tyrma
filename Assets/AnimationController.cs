using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class AnimationController : MonoBehaviour
{
    protected Animator animator;
    protected float horizontalInput;
    protected float verticalInput;
        // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
        animator.SetFloat("horizontalMoving", horizontalInput);
        animator.SetFloat("verticalMoving", verticalInput);
    }
}
