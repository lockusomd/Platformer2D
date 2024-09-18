using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private UserInput _userInput;
    [SerializeField] private float _speed;
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private Rotator _rotator;

    private void FixedUpdate()
    {
        _rigidbody.velocity = new Vector2(_userInput.Direction * _speed * Time.fixedDeltaTime, _rigidbody.velocity.y);

        _rotator.Rotate(_userInput.Direction);
    }
}