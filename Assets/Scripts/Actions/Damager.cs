using UnityEngine;

public class Damager : MonoBehaviour
{
    [SerializeField] private LayerMask _detectionLayer;
    [SerializeField] private int _power;
    [SerializeField] private float _detectionRadius = 1.0f;
    [SerializeField] private float _offsetDistance = 1.0f;

    public void Attack()
    {
        Collider2D[] hitColliders = Physics2D.OverlapCircleAll(GetPosition(), _detectionRadius, _detectionLayer);

        if (hitColliders.Length > 0)
        {
            foreach (var hitCollider in hitColliders)
            {
                if (hitCollider.TryGetComponent(out Health target))
                {
                    target.TakeDamage(_power);
                }
            }
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;

        Gizmos.DrawWireSphere(GetPosition(), _detectionRadius);
    }

    private Vector2 GetPosition()
    {
        Vector2 position = transform.position + transform.right * _offsetDistance;

        return position;
    }
}