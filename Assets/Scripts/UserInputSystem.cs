using UnityEngine;

public class UserInputSystem : MonoBehaviour
{
    public const string Horizontal = nameof(Horizontal);

    [SerializeField] private Mover _mover;
    [SerializeField] private Jumper _jumper;

    private void Update()
    {
        InputX();
        InputY();
    }

    private void InputX()
    {
        float direction = Input.GetAxis("Horizontal");

        _mover.SetDirection(direction);
    }

    private void InputY()
    {
        float force = Input.GetAxis("Vertical");

        if (force > 0)
        {
            _jumper.Jump();
        }
    }
}