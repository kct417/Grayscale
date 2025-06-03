using UnityEngine;

[System.Serializable]
public class BookData
{
    public string title;
    [TextArea(10, 20)] public string content;
    public Sprite coverImage;
}