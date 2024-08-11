using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Rigidbody2D _rigidbody;

    private float _direction = 0f;

    private void FixedUpdate()
    {
        _rigidbody.velocity = new Vector2(_direction * _speed * Time.fixedDeltaTime, _rigidbody.velocity.y);        
    }

    public void SetDirection(float direction)
    {
        _direction = direction;
    }
}