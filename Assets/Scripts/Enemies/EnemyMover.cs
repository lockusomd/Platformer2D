using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Transform[] _checkPoints;
    [SerializeField] private Rotator _rotator;

    private int _indexPoint = 0;

    public int IndexPoint => _indexPoint;

    private void FixedUpdate()
    {
        transform.position = Vector2.MoveTowards(transform.position, _checkPoints[_indexPoint].position, _speed * Time.fixedDeltaTime);

        if (transform.position == _checkPoints[_indexPoint].position)
            SetNextPoint();
    }

    private void SetNextPoint()
    {
        _indexPoint = ++_indexPoint % _checkPoints.Length;
        _rotator.Rotate(transform.position.x - _checkPoints[_indexPoint].position.x);
    }
}