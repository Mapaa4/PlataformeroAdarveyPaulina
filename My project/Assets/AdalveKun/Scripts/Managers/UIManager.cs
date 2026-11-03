using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Image _barraVida;
    [SerializeField] private Image _barraXP;
    [SerializeField] private GameObject _panelDefeat;
    [SerializeField] private GameObject _panelVictory;
    [SerializeField] private GameManager _gameManager;

    [Header("Eliminación de Objetos por Barra XP Llena")]
    [SerializeField] private string _tagObjetosMapa = "ObjetoMapa";
    private bool _barraXPYaSeLleno = false;

    private void Update()
    {
        if (_barraVida != null && _barraVida.fillAmount <= 0.0f)
        {
            if (_panelDefeat != null && !_panelDefeat.activeSelf)
                _panelDefeat.SetActive(true);
        }
        if (_barraXP != null)
        {
            if (_barraXP.fillAmount >= 1.0f && !_barraXPYaSeLleno)
            {
                _barraXPYaSeLleno = true;
                EliminarObjetosDelMapa();
            }
            else if (_barraXP.fillAmount < 1.0f)
            {
                _barraXPYaSeLleno = false;
            }
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

    //VIDAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
    public void ActualizarFillVida(float porcentaje)
    {
        if (_barraVida != null)
            _barraVida.fillAmount = Mathf.Clamp01(porcentaje);
    }

    public void ColorBarraVida(Color nuevoColor)
    {
        if (_barraVida != null)
            _barraVida.color = nuevoColor;
    }

    //ESTRELLAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
    public void ActualizarFillXP(float porcentaje)
    {
        if (_barraXP != null)
            _barraXP.fillAmount = Mathf.Clamp01(porcentaje);
    }

    public void ColorBarraXP(Color nuevoColor)
    {
        if (_barraXP != null)
            _barraXP.color = nuevoColor;
    }
    //AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
    private void EliminarObjetosDelMapa()
    {
        GameObject[] objetosAEliminar = GameObject.FindGameObjectsWithTag(_tagObjetosMapa);

        foreach (GameObject obj in objetosAEliminar)
        {
            Destroy(obj);
        }

        Debug.Log($"¡Barra de XP llena! Se eliminaron {objetosAEliminar.Length} objetos con la etiqueta '{_tagObjetosMapa}'.");
    }
}