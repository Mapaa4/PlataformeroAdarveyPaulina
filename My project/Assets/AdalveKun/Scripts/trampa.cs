using UnityEngine;

public class ObstaculoMortal : MonoBehaviour
{
    [SerializeField] private PlayerStats _playerstats;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            PlayerShield playerShield = collision.gameObject.GetComponent<PlayerShield>();

            if (playerShield != null && playerShield.hasShield)
            {
                playerShield.RemoveShield();
                Debug.Log("¡El escudo se cogio el daño!");
            }
            else
            {
                if (_playerstats != null)
                {
                    _playerstats.RestarVida(10);
                }
            }
        }
    }
}