using UnityEngine;

public class Book : MonoBehaviour
{
    public BookData bookData;

    private void OnMouseEnter() => Debug.Log("Mouse OVER book: " + bookData.title);
    private void OnMouseExit() => Debug.Log("Mouse LEFT book: " + bookData.title);
    private void OnMouseDown()
    {
        Debug.Log("Book clicked" + BookshelfManager.IsBookshelfOpen()); // Check if this appears in Console

        if (BookshelfManager.IsBookshelfOpen())
        {
            Debug.Log("Attempting to open book...");
            BookshelfManager.Instance.OpenBook(bookData); // Ensure bookData is assigned!
        }
    }
    
}