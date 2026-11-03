using UnityEngine;

public class Key : MonoBehaviour
{
    public enum KeyType { Blue, Orange, Green }
    [Header("Tipo de Llave")]
    [SerializeField] private KeyType keyType;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerInventory playerInventory = collision.GetComponent<PlayerInventory>();

            if (playerInventory != null)
            {
                string colorName = keyType.ToString();
                playerInventory.AddKey(colorName);
                KeyUIController hudController = Object.FindFirstObjectByType<KeyUIController>();
                if (hudController != null)
                {
                    switch (keyType)
                    {
                        case KeyType.Blue:
                            hudController.UnlockBlueKey();
                            break;
                        case KeyType.Orange:
                            hudController.UnlockOrangeKey();
                            break;
                        case KeyType.Green:
                            hudController.UnlockGreenKey();
                            break;
                    }
                }
                Destroy(gameObject);
            }
        }
    }
}