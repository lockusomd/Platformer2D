using UnityEngine;

public class TargetDetector : MonoBehaviour
{
    [SerializeField] private Damager _damager;

    public Transform Target { get; private set; }

    public bool IsDetected { get; private set; }

    private void FixedUpdate()
    {
        if (IsDetected)
            _damager.Attack();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Player component))
        {
            Target = component.transform;

            IsDetected = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent<Player>(out _))
        {
            IsDetected = false;
        }
    }
}
