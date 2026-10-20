using UnityEngine;

public class SeguimientoCamara : MonoBehaviour
{
    [SerializeField] private Transform _objetivo;

    private void Update()
    {
        transform.position = new Vector3(_objetivo.position.x, transform.position.y, transform.position.z);
    }
}
