using UnityEngine;
using UnityEngine.InputSystem;

public class InteractionDetector : MonoBehaviour
{
    private InteractableInterface interactableInRange = null; //Closest Interactable Object
    public GameObject icon; //interaction icon

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        icon.SetActive(false);
    }

    public void OnInteract(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            interactableInRange?.Interact();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out InteractableInterface interactable) && interactable.CanInteract())
        {
            interactableInRange = interactable;
            icon.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out InteractableInterface interactable) && interactable == interactableInRange)
        {
            interactableInRange = null;
            icon.SetActive(false);
        }
    }
}
