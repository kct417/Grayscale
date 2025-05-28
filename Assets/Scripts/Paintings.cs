using JetBrains.Annotations;
using UnityEngine;

public class Paintings : MonoBehaviour, InteractableInterface
{

    public string PaintingsID
    {
        get; private set;
    }

    public GameObject paintingsPanel; //here you would change the object to whatever the interaction is



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PaintingsID ??= InteractionHelper.GenerateUniqueID(gameObject);
    }


    public bool CanInteract()
    {
        return true;
    }

    public void Interact()
    {
        Debug.Log("Interact called on painting");
        LookAtPaintings();
    }

    private void LookAtPaintings()
    {
        Debug.Log("Attempting to open panel");
        if (paintingsPanel != null)
        {
            paintingsPanel.SetActive(true);
            Debug.Log("Panel should be visible now");
        }
        else
        {
            Debug.LogError("paintingsPanel is not assigned!");
        }
    }
    

}
