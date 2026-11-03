using UnityEngine;

public class Shield : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerShield playerShield = collision.GetComponent<PlayerShield>();

            if (playerShield != null && !playerShield.hasShield)
            {
                playerShield.EquipShield();
                Destroy(gameObject);
            }
        }
    }
}