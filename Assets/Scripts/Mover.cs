using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private Rotator _rotator;

    public void Move(float direction)
    {
        _rigidbody.velocity = new Vector2(direction * _speed * Time.fixedDeltaTime, _rigidbody.velocity.y);
        _rotator.Rotate(direction);
    }
}