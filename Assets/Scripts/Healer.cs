using UnityEngine;

public class Healer : MonoBehaviour
{
    [SerializeField] private Victim _victim;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent<Aid>(out Aid component))
        {
            _victim.Heal(component.Health);
        }
    }
}