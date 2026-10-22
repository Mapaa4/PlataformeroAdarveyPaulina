using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    private Door doorScript;

    void Start()
    {
        doorScript = GetComponentInParent<Door>();
    }

    private void OnTriggerStay(Collider other)
    {
        // Si el jugador presiona la tecla 'E' estando cerca de la puerta
        if (other.CompareTag("Player") && Input.GetKeyDown(KeyCode.E))
        {
            if (doorScript != null)
            {
                doorScript.Interact(other.gameObject);
            }
        }
    }
}