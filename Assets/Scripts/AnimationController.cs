using UnityEngine;

public class AnimationController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private Animator _animator;

    private void FixedUpdate()
    {
        if (_rigidbody.velocity.x > 0)
        {
            _animator.SetInteger("Run", 1);
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        else if (_rigidbody.velocity.x < 0)
        {
            _animator.SetInteger("Run", 1);
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }
        else
        {
            _animator.SetInteger("Run", 0);
        }

        if (_rigidbody.velocity.y > 0)
            _animator.SetInteger("Jump", 1);
        else if (_rigidbody.velocity.y < 0)
            _animator.SetInteger("Jump", -1);
        else
            _animator.SetInteger("Jump", 0);
    }
}
