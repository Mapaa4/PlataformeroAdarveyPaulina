using UnityEngine;

public class EstrellaColeccionable : MonoBehaviour
{
    [SerializeField] private int _valorXP = 25;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            XPStars gestorXP = Object.FindFirstObjectByType<XPStars>();
            if (gestorXP != null)
            {
                gestorXP.SumarXP(_valorXP);
            }

            Destroy(gameObject);
        }
    }
}