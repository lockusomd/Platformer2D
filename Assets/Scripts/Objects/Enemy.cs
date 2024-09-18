using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private EnemyMover _enemyMover;
    [SerializeField] private Chaser _chaser;

    private void Update()
    {
        if (_chaser.IsChaser)
            _enemyMover.SetTarget(_chaser.Target);
    }
}
