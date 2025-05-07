using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BedController : MonoBehaviour, Iinteractable
{
    [SerializeField]
    protected GameObject Player;
    [SerializeField]
    protected BoxCollider2D Bed;

    protected PlayerController playerController;
    protected bool canMove = true;

    protected virtual void Start()
    {
        if (Player != null)
        {
            playerController = Player.GetComponent<PlayerController>();
        }
        else
        {
            Debug.LogError("Player is null");
        }
    }

    public void Interact()
    {
        Debug.Log("Interaction with bed");

        if (canMove)
        {
            Bed.enabled = false;
            Player.transform.position = new Vector3(21.65f,-0.11f,0f);
            canMove = false;
            playerController.enabled = canMove;
        }
        else
        {
            Bed.enabled = true;
            Player.transform.position = new Vector3(17.9f,-0.27f,0f);
            canMove = true;
            playerController.enabled = canMove;
        }
    }
}
