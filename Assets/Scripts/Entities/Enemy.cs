using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private EnemyMover _enemyMover;
    [SerializeField] private TargetDetector _targetDetector;

    private bool _isPatrol = true;

    private void Update()
    {
        if (_targetDetector.IsDetected)
        {
            _enemyMover.SetTarget(_targetDetector.Target);

            _isPatrol = false;
        }
        else if (_isPatrol == false)
        {
            _enemyMover.Patrol();

            _isPatrol = true;
        }
    }
}
