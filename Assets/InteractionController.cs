using UnityEngine;

public class InteractionController : MonoBehaviour
{
    protected Iinteractable interactable;

    private void Update()
    {
        if (interactable != null && Input.GetKeyDown(KeyCode.E))
        {
            interactable.Interact();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        interactable = collision.gameObject.GetComponent<Iinteractable>();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        interactable = null;
    }
}
