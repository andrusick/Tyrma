using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BedController :PlayerController,Iinteractable
{
    [SerializeField]
    protected GameObject Player;
    [SerializeField]
    protected BoxCollider2D Bed;
    public void Interact()
    {
        Debug.Log("1111");
        Bed.enabled = false;
        Player.transform.position = new Vector3(21.65f,-0.11f,0f);
        isMove = false;
        
    }
    public void Interact_1()
    {
        Player.transform.position = new Vector3(17.9f,-0.27f,0f);
        isMove = true;
        Bed.enabled = false;
    }
}
