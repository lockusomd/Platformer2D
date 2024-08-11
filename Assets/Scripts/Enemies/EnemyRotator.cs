using UnityEngine;

public class EnemyRotator : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private EnemyMover _enemyMover;

    private void FixedUpdate()
    {
        if (_enemyMover.IndexPoint == 0)
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        else if (_enemyMover.IndexPoint == 1)
            transform.localRotation = Quaternion.Euler(0, 180, 0);
    }
}
