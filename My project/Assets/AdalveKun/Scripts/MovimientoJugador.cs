using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{
    [SerializeField] private float _fuerzaSalto = 5f;
    [SerializeField] private float _velocidadMovimiento = 5f;
    [SerializeField] private Rigidbody2D _cuerpoRigido2D;
    [SerializeField] private DetectorSuelo _detectorSuelo;

    private float _movimientoHorizontal;
    private bool _intentandoSaltar;

    private void Awake()
    {
        if (_cuerpoRigido2D == null)
            _cuerpoRigido2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _movimientoHorizontal = Input.GetAxisRaw("Horizontal") * _velocidadMovimiento;

        if (Input.GetKeyDown(KeyCode.Space) && _detectorSuelo.estaEnSuelo)
        {
            _intentandoSaltar = true;
        }
    }

    private void FixedUpdate()
    {

        _cuerpoRigido2D.linearVelocity = new Vector2(_movimientoHorizontal, _cuerpoRigido2D.linearVelocity.y);

        if (_intentandoSaltar)
        {
            _cuerpoRigido2D.AddForce(Vector2.up * _fuerzaSalto, ForceMode2D.Impulse);
            _intentandoSaltar = false;
            Debug.Log("¡Salto Saltado Saltador!");
            // no se que hacer con mi vida
        }
    }
}