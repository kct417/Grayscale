using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class BookData
{
    public string title;
    [TextArea(10, 20)] public string contentLeft;
    [TextArea(10, 20)] public string contentRight;

    public Sprite coverImage;
    
    public Sprite puzzle;
}