using UnityEngine;

public class Attacker : MonoBehaviour
{
    [SerializeField] private UserInput _userInput;
    [SerializeField] private GroundDetector _groundDetector;
    [SerializeField] private Damager _damager;

    public bool IsAttack { get; private set; } = false;

    private void Update()
    {
        if (_userInput.IsAttack && _groundDetector.IsGround)
            IsAttack = true;
    }

    private void FixedUpdate()
    {
        if (IsAttack)
        {
            _damager.Attack();

            IsAttack = false;
        }
    }
}
