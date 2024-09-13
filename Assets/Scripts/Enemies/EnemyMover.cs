using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Transform[] _checkPoints;
    [SerializeField] private Rotator _rotator;
    [SerializeField] private Transform _target;

    private int _indexPoint = 0;

    private void FixedUpdate()
    {
        transform.position = Vector2.MoveTowards(transform.position, _target.position, _speed * Time.fixedDeltaTime);

        if (transform.position == _target.position)
            SetNextPoint();
    }

    private void SetNextPoint()
    {
        _indexPoint = ++_indexPoint % _checkPoints.Length;
        SetTarget(_checkPoints[_indexPoint]);
    }

    public void SetTarget(Transform target)
    {
        _target = target;
        _rotator.Rotate(transform.position.x - _target.position.x);
    }

    public void Patrol()
    {
        SetNextPoint();
    }
}