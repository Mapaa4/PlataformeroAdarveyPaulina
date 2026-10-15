using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private int _puntosVida = 100;
    [SerializeField] private int _vidaMaxima = 100;
    [SerializeField] private UIManager _uiManager;
    [SerializeField] private GameManager _gameManager;
    public void RestarVida(int daño)
    {
        _puntosVida -= daño;
        if (_puntosVida < 0) _puntosVida = 0;

        ActualizarBarra();
        Debug.Log("Vida actual: " + _puntosVida);
    }
    public void SumarVida(int cantidad)
    {
        _puntosVida += cantidad;

        if (_puntosVida > _vidaMaxima)
        {
            _puntosVida = _vidaMaxima;
        }

        ActualizarBarra();
        Debug.Log("Vida actual: " + _puntosVida);
    }
    private void ActualizarBarra()
    {
        float porcentajeVida = (float)_puntosVida / _vidaMaxima;
        if (_uiManager != null)
        {
            _uiManager.ActualizarFillAmount(porcentajeVida);

            if (porcentajeVida <= 0.25f)
            {
                _uiManager.ColorBarra(Color.red);
            }
            else if (porcentajeVida <= 0.6f)
            {
                _uiManager.ColorBarra(Color.yellow);
            }
            else
            {
                _uiManager.ColorBarra(Color.green);
            }
            if (_puntosVida <= 0)
            {
                _gameManager.PausarElJuego();
            }
        }
    }
}