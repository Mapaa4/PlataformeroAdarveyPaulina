using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [Header("Referencias de UI")]
    [SerializeField] private Image _barra;
    [SerializeField] private GameObject _panelDefeat;
    [SerializeField] private GameObject _panelVictory;

    [Header("Referencias del Juego")]
    [SerializeField] private GameManager _gameManager;

    private void Update()
    {

        if (_barra != null && _barra.fillAmount <= 0.0f)
        {
            if (_panelDefeat != null)
                _panelDefeat.SetActive(true);
        }
    }

    private void OnCollisionEnter2D(Collision2D colision)
    {

        if (colision.gameObject.CompareTag("Player"))
        {
            if (_gameManager != null)
                _gameManager.PausarElJuego();

            if (_panelVictory != null)
                _panelVictory.SetActive(true);
        }
    }
    public void ActualizarFillAmount(float porcentaje)
    {
        if (_barra != null)
            _barra.fillAmount = Mathf.Clamp01(porcentaje);
    }

    public void SumarFillAmount(float amount)
    {
        if (_barra != null)
            _barra.fillAmount = Mathf.Clamp01(_barra.fillAmount + amount);
    }

    public void RestarFillAmount(float amount)
    {
        if (_barra != null)
            _barra.fillAmount = Mathf.Clamp01(_barra.fillAmount - amount);
    }

    public void ColorBarra(Color nuevoColor)
    {
        if (_barra != null)
            _barra.color = nuevoColor;
    }
}