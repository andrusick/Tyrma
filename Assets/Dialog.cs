using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialog : MonoBehaviour
{
    [SerializeField]
    protected Text dialoguetext;
    [SerializeField]
    protected float timeBetweenRepl = 2f;
    protected Image background;

    protected virtual void Start()
    {
        background = GetComponent<Image>();
    }

    public virtual IEnumerator EnableDialogueView()
    {
        for (int i=0; i <= 255; i++)
        {
            background.color = new Color(0,0,0, i);
            yield return new WaitForEndOfFrame();
        }
        dialoguetext.enabled = true;

    }
    public virtual IEnumerator DisableDialogueView()
    {
        dialoguetext.enabled = false;
         for (int i=255; i >= 0; i--)
        {
            background.color = new Color(0,0,0, i);
            yield return new WaitForEndOfFrame();
        }
    }
        
   
    public virtual IEnumerator ShowText(string message)
    {
        dialoguetext.text = "";
            foreach (var letter in message)
            {
                dialoguetext.text += letter;
                yield return new WaitForSeconds(0.1f);
            }
        
        
        
    }
}
