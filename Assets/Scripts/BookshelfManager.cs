using UnityEngine;
using UnityEngine.EventSystems;

public class BookshelfManager : MonoBehaviour
{   
    public static BookshelfManager Instance { get; private set; }
        
    public GameObject bookshelfPanel;
    public Book[] books; 
    public GameObject bookPopupPrefab;
    public KeyCode toggleKey = KeyCode.E;
    private bool isBookshelfOpen = false;
    private Canvas mainCanvas;

    private void OnMouseEnter() => Debug.Log("Mouse OVER bookshelf");

    private void Awake()
    {
        if (Instance != null && Instance != this)
            Destroy(gameObject);
        else
            Instance = this;

        if (Camera.main.GetComponent<Physics2DRaycaster>() == null)
        {
            Camera.main.gameObject.AddComponent<Physics2DRaycaster>();
        }

        mainCanvas = FindFirstObjectByType<Canvas>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(toggleKey))
        {
            ToggleBookshelf();
        }
    }

    public void ToggleBookshelf()
    {
        isBookshelfOpen = true;
        bookshelfPanel.SetActive(true);
        Debug.Log("Bookshelf toggled: " + isBookshelfOpen);
    }

    public static bool IsBookshelfOpen()
    {
        Debug.Log("Check Bookshelf Open");
        return Instance != null && Instance.isBookshelfOpen;
    }

    // Called by individual books when clicked
    public void OpenBook(BookData bookData)
    {
        Debug.Log("Open Book 1");
        GameObject popup = Instantiate(bookPopupPrefab, Vector3.zero, Quaternion.identity);
        popup.transform.SetParent(mainCanvas.transform, false);
        
        BookPopup popupScript = popup.GetComponent<BookPopup>();
        popupScript.Setup(bookData);
    }
}
