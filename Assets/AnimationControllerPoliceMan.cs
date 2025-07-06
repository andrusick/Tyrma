using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControllerPoliceMan : MonoBehaviour
{
    protected Animator anim;
    protected Patrolling patrolling;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        patrolling = GetComponent<Patrolling>();
    }

    // Update is called once per frame
    void Update()
    {
        if (patrolling.Vector == false)
        {
            anim.SetBool("direction", false);
        }
        else
        {
            anim.SetBool("direction", true);
        }
    }
}
