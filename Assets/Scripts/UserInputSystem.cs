using UnityEngine;

public class UserInputSystem : MonoBehaviour
{
    public const string Horizontal = nameof(Horizontal);

    [SerializeField] private Mover _mover;
    [SerializeField] private Jumper _jumper;

    private float _direction;

    private void Update()
    {
        InputX();
        InputY();
    }

    private void InputX()
    {
        _direction = Input.GetAxis("Horizontal");

        _mover.SetDirection(_direction);
    }

    private void InputY()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            _jumper.Jump();
        }
    }
}