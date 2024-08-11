using UnityEngine;

public class Jumper : MonoBehaviour
{
    [SerializeField] private float _force = 0;
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private GroundChecker _groundChecker;

    private bool _isJump = false;

    private void FixedUpdate()
    {
        if (_isJump)
        {
            _isJump = false;
            _rigidbody.velocity = new Vector2(0,0);
            _rigidbody.AddForce(Vector2.up * _force, ForceMode2D.Impulse);
        }
    }

    public void Jump()
    {
        if (_groundChecker.IsGround)
            _isJump = true;
    }
}