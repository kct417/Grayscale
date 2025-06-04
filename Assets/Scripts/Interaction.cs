using JetBrains.Annotations;
using UnityEngine;

public class Interaction : MonoBehaviour, InteractableInterface
{

    public string objectID
    {
        get; private set;
    }

    public GameObject panel; //here you would change the object to whatever the interaction is



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        objectID ??= InteractionHelper.GenerateUniqueID(gameObject);
    }


    public bool CanInteract()
    {
        return true;
    }

    public void Interact()
    {
        LookAtObject();
    }

    private void LookAtObject()
    {
        if (panel != null)
        {
            bool isActive = panel.activeSelf;
            panel.SetActive(!isActive);
        }
    }
    

}
