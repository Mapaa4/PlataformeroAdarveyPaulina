using UnityEngine;

public class Door : MonoBehaviour
{
    public enum DoorColor { Blue, Orange, Green }
    [Header("Color de la Puerta")]
    [SerializeField] private DoorColor doorColor;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerInventory playerInventory = collision.gameObject.GetComponent<PlayerInventory>();

            if (playerInventory != null)
            {
                string colorString = doorColor.ToString();
                if (playerInventory.HasKeyOfType(colorString))
                {
                    OpenDoor();
                }
                else
                {
                    Debug.Log($"La puerta está cerrada. Necesitas la llave {colorString}.");
                }
            }
        }
    }

    void OpenDoor()
    {
        Debug.Log("¡Puerta abierta!");
        gameObject.SetActive(false);
    }
}