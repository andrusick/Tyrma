using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCDialogueController : MonoBehaviour
{
    [SerializeField]
    protected List<string> repliks;
    [SerializeField]
    protected Dialog dialogView;

    void OnTriggerEnter2D(Collider2D other)
    {
        dialogView.ShowText(repliks);
    }
}
