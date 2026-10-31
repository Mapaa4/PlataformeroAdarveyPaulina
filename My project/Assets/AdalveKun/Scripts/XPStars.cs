using UnityEngine;

public class XPStars : MonoBehaviour
{
    [SerializeField] private int _puntosXP = 0;
    [SerializeField] private int _xpMaxima = 100;
    [SerializeField] private UIManager _uiManager;

    public void SumarXP(int cantidad)
    {
        _puntosXP += cantidad;
        if (_puntosXP > _xpMaxima)
        {
            _puntosXP = _xpMaxima;
        }

        ActualizarBarraXP();
    }

    private void ActualizarBarraXP()
    {
        float porcentajeXP = (float)_puntosXP / _xpMaxima;

        if (_uiManager != null)
        {
            _uiManager.ActualizarFillXP(porcentajeXP);

            if (porcentajeXP >= 1.0f)
            {
                _uiManager.ColorBarraXP(Color.cyan);
            }
        }
    }
}