using UnityEngine;
using UnityEngine.EventSystems;

public class BookshelfManager : MonoBehaviour
{   
    public static BookshelfManager Instance { get; private set; }
        
    public GameObject bookshelfPanel;
    public Book[] books; 
    public GameObject bookPopupPrefab;
    public KeyCode toggleKey;
    private bool isBookshelfOpen = false;
    private Canvas mainCanvas;


    private void Awake()
    {
        if (Instance != null && Instance != this)
            Destroy(gameObject);
        else
            Instance = this;

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
        bookshelfPanel.SetActive(isBookshelfOpen);
    }

    public static bool IsBookshelfOpen()
    {
        return Instance != null && Instance.isBookshelfOpen;
    }

    // Called by individual books when clicked
    public void OpenBook(BookData bookData)
    {
        GameObject popup = Instantiate(bookPopupPrefab, Vector3.zero, Quaternion.identity);
        popup.transform.SetParent(mainCanvas.transform, false);
        
        BookPopup popupScript = popup.GetComponent<BookPopup>();
        popupScript.Setup(bookData);
    }
}
