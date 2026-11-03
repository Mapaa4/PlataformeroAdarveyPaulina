using UnityEngine;
public class FakeHeal : MonoBehaviour
{
    [SerializeField] private PlayerStats _playerstats;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {

            PlayerStats stats = collision.GetComponent<PlayerStats>();

            if (stats != null)
            {
                _playerstats.RestarVida(10);

                Destroy(gameObject);
            }
        }
    }
}