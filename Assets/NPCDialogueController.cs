using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCDialogueController : MonoBehaviour
{
    protected float dialoguePause = 2f;
    [SerializeField]
    protected NPCDialogueData repliks;
    [SerializeField]
    protected Dialog dialogView;

    void OnTriggerEnter2D(Collider2D other)
    {
        StartCoroutine(StartDialogue());
    }

     protected virtual IEnumerator StartDialogue()
    {
        
        var dialogue = repliks.Repliks;


        string message = dialogue[Random.Range(0,dialogue.Count - 1)];

        yield return StartCoroutine(dialogView.EnableDialogueView());
        yield return StartCoroutine(dialogView.ShowText(message));
        yield return new WaitForSeconds(dialoguePause);
        yield return StartCoroutine(dialogView.DisableDialogueView());


        //dialogView.ShowText(message);
            
    }
}
