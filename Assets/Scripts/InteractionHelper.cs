using UnityEngine;

public static class InteractionHelper
{
    public static string GenerateUniqueID(GameObject obj)
    {
        //example: Paintings_3_4
        return $"{obj.scene.name} {obj.transform.position.x} {obj.transform.position.y}";
    }
}
