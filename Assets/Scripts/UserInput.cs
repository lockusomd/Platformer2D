using UnityEngine;

public class UserInput : MonoBehaviour
{
    public const string Horizontal = nameof(Horizontal);
    public const KeyCode Jump = KeyCode.Space;

    [SerializeField] private Mover _mover;
    [SerializeField] private Jumper _jumper;

    private float _direction;
    private bool _isJump;

    public float Direction => _direction;
    public bool IsJump => _isJump;

    private void Update()
    {
        _direction = Input.GetAxis(Horizontal);

        if (Input.GetKeyDown(Jump))
            _isJump = true;
        else
            _isJump = false;
    }
}