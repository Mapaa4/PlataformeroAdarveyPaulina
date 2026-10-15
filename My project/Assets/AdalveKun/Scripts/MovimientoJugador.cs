using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{
    [SerializeField] private float _fuerzaSalto = 5f;
    [SerializeField] private float _velocidadMovimiento = 5f;
    [SerializeField] private Rigidbody2D _cuerpoRigido2D;
    [SerializeField] private DetectorSuelo _detectorSuelo;

    private void Awake()
    {
        _cuerpoRigido2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (_detectorSuelo.estaEnSuelo)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                _cuerpoRigido2D.AddForce(Vector2.up * _fuerzaSalto, ForceMode2D.Impulse);
                Debug.Log("Oprimí la tecla");
            }
        }
        _cuerpoRigido2D.linearVelocity = new Vector2(1 * _velocidadMovimiento, _cuerpoRigido2D.linearVelocity.y);
    }
}
