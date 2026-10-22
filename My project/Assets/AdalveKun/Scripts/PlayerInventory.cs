using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    private int keysCollected = 0;

    public void AddKey()
    {
        keysCollected++;
        Debug.Log("¡Llave recolectada! Total de llaves: " + keysCollected);
    }

    public bool HasKey()
    {
        return keysCollected > 0;
    }

    public void UseKey()
    {
        if (keysCollected > 0)
        {
            keysCollected--;
        }
    }
}