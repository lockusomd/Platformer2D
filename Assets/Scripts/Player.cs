using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private UserInput _userInput;
    [SerializeField] private Mover _mover;
    [SerializeField] private Jumper _jumper;
    [SerializeField] private GroundDetector _groundDetector;

    private void Update()
    {
        if (_userInput.Direction != 0)
            _mover.Move(_userInput.Direction);

        if (_userInput.IsJump && _groundDetector.IsGround)
            _jumper.Jump();
    }
}
