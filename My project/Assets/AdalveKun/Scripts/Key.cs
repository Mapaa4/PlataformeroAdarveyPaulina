using UnityEngine;

public class Key : MonoBehaviour
{
    [Tooltip("Identificador único para la llave (ej. 'LlaveRoja', 'LlavePrincipal')")]
    public string keyID;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();

            if (playerInventory != null)
            {
                playerInventory.AddKey(keyID);
                Debug.Log("Llave recogida: " + keyID);
                Destroy(gameObject);
            }
        }
    }
}