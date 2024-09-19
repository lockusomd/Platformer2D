using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private EnemyMover _enemyMover;
    [SerializeField] private Chaser _chaser;

    private bool _isPatrol = true;

    private void Update()
    {
        if (_chaser.IsChaser)
        {
            _enemyMover.SetTarget(_chaser.Target);

            _isPatrol = false;
        }
        else if (_isPatrol == false)
        {
            _enemyMover.Patrol();

            _isPatrol = true;
        }
    }
}
