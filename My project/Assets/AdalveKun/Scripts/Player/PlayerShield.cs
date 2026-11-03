using UnityEngine;

public class PlayerShield : MonoBehaviour
{
    [Header("Configuración del Escudo")]
    public bool hasShield = false;

    public void EquipShield()
    {
        hasShield = true;
        Debug.Log("¡Escudo equipado!");
    }

    public void RemoveShield()
    {
        hasShield = false;
        Debug.Log("¡Escudo perdido!");
    }
}