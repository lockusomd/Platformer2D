using UnityEngine;

public class Healer : MonoBehaviour
{
    [SerializeField] private Health _health;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Aid component))
        {
            _health.Recovery(component.Health);
        }
    }
}