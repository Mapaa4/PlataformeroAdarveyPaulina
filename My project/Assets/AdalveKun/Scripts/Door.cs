using UnityEngine;

public class Door : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerInventory playerInventory = collision.gameObject.GetComponent<PlayerInventory>();

            if (playerInventory != null && playerInventory.HasKey())
            {
                playerInventory.UseKey();
                OpenDoor();
            }
            else
            {
                Debug.Log("La puerta está cerrada. Necesitas una llave.");
            }
        }
    }

    void OpenDoor()
    {
        Debug.Log("¡Puerta abierta!");
        gameObject.SetActive(false);
    }
}