using UnityEngine;

public class HealingItem : MonoBehaviour
{
    [SerializeField] private int _Healamount = 20;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {

            PlayerStats stats = collision.GetComponent<PlayerStats>();

            if (stats != null)
            {
                stats.SumarVida(_Healamount);

                Destroy(gameObject);
            }
        }
    }
}