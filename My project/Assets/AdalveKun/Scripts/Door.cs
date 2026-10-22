using UnityEngine;

public class Door : MonoBehaviour
{
    [Tooltip("ID de la llave necesaria para abrir esta puerta. Déjalo vacío si no requiere llave.")]
    public string requiredKeyID;

    // ¿PORQUE ELEGI ESTA CARRERA?
    public void Interact(GameObject player)
    {
        // ESTOY MAMADO
        if (!string.IsNullOrEmpty(requiredKeyID))
        {
            PlayerInventory playerInventory = player.GetComponent<PlayerInventory>();

            if (playerInventory != null && playerInventory.HasKey(requiredKeyID))
            {
                OpenAndDestroyDoor();
                Debug.Log("¡Puerta abierta y destruida con éxito!");
            }
            else
            {
                Debug.Log("Necesitas la llave: " + requiredKeyID + " para abrir esta puerta.");
            }
        }
        else
        {
 // :(
            OpenAndDestroyDoor();
        }
    }

    void OpenAndDestroyDoor()
    {
 // PUTAA
        Destroy(gameObject);
    }
}