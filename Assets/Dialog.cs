using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialog : MonoBehaviour
{
    [SerializeField]
    protected Text dialoguetext;
    protected Image background;

    protected virtual void Start()
    {
        background = GetComponent<Image>();
    }
    public virtual void ShowText(List<string> message)
    {
        StartCoroutine(DialogueCourutine(message));
    }
    protected virtual IEnumerator DialogueCourutine(List<string> message)
    {
        // for (int i=0; i <= 255; i++)
        // {
        //     background.color = new Color(0,0,0, i);
        //     yield return new WaitForEndOfFrame();
        // }
        // dialoguetext.enabled = true;

        foreach (var repl in message)
        {
            foreach (var letter in repl)
            {
                dialoguetext.text += letter;
                yield return new WaitForSeconds(0.1f);
            }
            message.Remove(repl);
            yield return new WaitForSeconds(3f);
        }
        // dialoguetext.enabled = false;
        //  for (int i=255; i >= 0; i--)
        // {
        //     background.color = new Color(0,0,0, i);
        //     yield return new WaitForEndOfFrame();
        // }
    }
}
