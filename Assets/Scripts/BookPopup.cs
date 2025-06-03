using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BookPopup : MonoBehaviour
{
    public TMP_Text title;
    public TMP_Text content;
    public Image cover;
    public Button close;
    
    private void Awake()
    {
        close.onClick.AddListener(Close);
    }
    
    public void Setup(BookData data)
    {
        title.text = data.title;
        content.text = data.content;
        cover.sprite = data.coverImage;
    }
    
    private void Close()
    {
        Destroy(gameObject);
    }
}