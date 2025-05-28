using JetBrains.Annotations;
using UnityEngine;

public class Paintings : MonoBehaviour, InteractableInterface
{

    public string PaintingsID
    {
        get; private set;
    }

    public GameObject item; //here you would change the object to whatever the interaction is



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
        LookAtPaintings();
    }

    private void LookAtPaintings()
    {
        //OpenPopUp
        if (item)
        {
            GameObject droppedItem = Instantiate(item, transform.position + Vector3.down, Quaternion.identity);
        }
    }
    

}
