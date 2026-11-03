using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public bool hasBlueKey = false;
    public bool hasOrangeKey = false;
    public bool hasGreenKey = false;
    public void AddKey(string keyColor)
    {
        switch (keyColor.ToLower())
        {
            case "blue":
                hasBlueKey = true;
                Debug.Log("¡Llave Azul cogida!");
                break;
            case "orange":
                hasOrangeKey = true;
                Debug.Log("¡Llave Naranja mascada!");
                break;
            case "green":
                hasGreenKey = true;
                Debug.Log("¡Llave Verde mordida!");
                break;
        }
    }
    public bool HasAnyKey()
    {
        return hasBlueKey || hasOrangeKey || hasGreenKey;
    }

    public bool HasKeyOfType(string keyColor)
    {
        switch (keyColor.ToLower())
        {
            case "blue": return hasBlueKey;
            case "orange": return hasOrangeKey;
            case "green": return hasGreenKey;
            default: return false;
        }
    }
}