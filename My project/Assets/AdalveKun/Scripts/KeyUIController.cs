using UnityEngine;
using UnityEngine.UI;
public class KeyUIController : MonoBehaviour
{
//llaves silueta
    [SerializeField] private Image blueKeyImage;
    [SerializeField] private Image orangeKeyImage;
    [SerializeField] private Image greenKeyImage;
//llaves coloreadas
    [SerializeField] private Sprite blueKeySprite;
    [SerializeField] private Sprite orangeKeySprite;
    [SerializeField] private Sprite greenKeySprite;

    public void UnlockBlueKey()
    {
        if (blueKeyImage != null && blueKeySprite != null)
        {
            blueKeyImage.sprite = blueKeySprite;
            blueKeyImage.gameObject.SetActive(true);
        }
        else
        {
            Debug.LogWarning("Falta asignar la imagen o el sprite de la llave azul en el KeyUIController.");
        }
    }

    public void UnlockOrangeKey()
    {
        if (orangeKeyImage != null && orangeKeySprite != null)
        {
            orangeKeyImage.sprite = orangeKeySprite;
            orangeKeyImage.gameObject.SetActive(true);
        }
        else
        {
            Debug.LogWarning("Falta asignar la imagen o el sprite de la llave naranja en el KeyUIController.");
        }
    }

    public void UnlockGreenKey()
    {
        if (greenKeyImage != null && greenKeySprite != null)
        {
            greenKeyImage.sprite = greenKeySprite;
            greenKeyImage.gameObject.SetActive(true);
        }
        else
        {
            Debug.LogWarning("Falta asignar la imagen o el sprite de la llave verde en el KeyUIController.");
        }
    }
}