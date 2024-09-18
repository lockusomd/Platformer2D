using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private Animator _animator;
    [SerializeField] private GroundDetector _groundDetector;

    private int _velocityJump = 0;
    private int _velocityRun = 0;

    private void FixedUpdate()
    {
        _velocityJump = Mathf.RoundToInt(_rigidbody.velocity.y);
        _velocityRun = Mathf.RoundToInt(_rigidbody.velocity.x);

        if (_velocityRun != 0 && _groundDetector.IsGround)
            _animator.SetBool(PlayerAnimatorData.Params.Run, true);
        else
            _animator.SetBool(PlayerAnimatorData.Params.Run, false);

        _animator.SetInteger(PlayerAnimatorData.Params.Jump, _velocityJump);
    }
}
