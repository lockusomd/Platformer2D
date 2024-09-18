using UnityEngine;

public class Jumper : MonoBehaviour
{
    [SerializeField] private UserInput _userInput;
    [SerializeField] private float _force = 0;
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private GroundDetector _groundDetector;

    private bool _isJump = false;

    private void Update()
    {
        if (_userInput.IsJump && _groundDetector.IsGround)
            _isJump = true;
    }

    private void FixedUpdate()
    {
        if (_isJump)
        {
            _rigidbody.AddForce(Vector2.up * _force, ForceMode2D.Impulse);

            _isJump = false;
        }
    }
}