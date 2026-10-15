using UnityEngine;

public class trampa : MonoBehaviour
{
    [SerializeField] private PlayerStats _playerstats;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            _playerstats.RestarVida(10);
        }
    }
}
