using UnityEngine;
using UnityEngine.UI;

public class Book : MonoBehaviour
{
    public BookData bookData; // Assign in Inspector!
    private Button button;

    private void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(OnClick);
    }

    private void OnClick()
    {
        if (BookshelfManager.IsBookshelfOpen())
        {
            BookshelfManager.Instance.OpenBook(bookData);
        }
    }
    
}