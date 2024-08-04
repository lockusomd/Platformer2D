using UnityEngine;

public class Jumper : MonoBehaviour
{
    [SerializeField] private float _force = 0;
    [SerializeField] private Rigidbody2D _rigidbody;

    private bool _isGround = false;
    private bool _isJump = false;

    private void FixedUpdate()
    {
        if (_isJump)
        {
            _rigidbody.AddForce(Vector2.up * _force, ForceMode2D.Impulse);
            _isGround = false;
            _isJump = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Ground component))
            _isGround = true;
    }

    public void Jump()
    {
        if(_isGround)
            _isJump = true;
    }
}