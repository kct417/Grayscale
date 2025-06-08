using TMPro;
using UnityEngine;

public class GetCipherShift : MonoBehaviour
{
    public RectTransform outerCircle;
    public RectTransform innerCircle;
    public TextMeshProUGUI shiftNum;

    // Update is called once per frame
    void Update()
    {
        float outerZ = outerCircle.eulerAngles.z;
        float innerZ = innerCircle.eulerAngles.z;

        float angleDifference = Mathf.DeltaAngle(innerZ, outerZ);
        if (angleDifference < 0)
            angleDifference += 360f; 

        float divisionSize = 360f / 26f;
        int index = Mathf.RoundToInt(angleDifference / divisionSize) % 26;

        shiftNum.text = index.ToString();
    }
}
