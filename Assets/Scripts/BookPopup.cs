using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BookPopup : MonoBehaviour
{
    public TMP_Text title;
    public TMP_Text contentBox1;
    public TMP_Text contentBox2;
    public Image cover;
    public Button close;
    
    private void Awake()
    {
        close.onClick.AddListener(Close);
    }
    
    public void Setup(BookData data)
    {
        title.text = data.title;
        contentBox1.text = data.contentLeft;
        contentBox2.text = data.contentRight;
        cover.sprite = data.coverImage;
    }
    
    private void Close()
    {
        Destroy(gameObject);
    }
}