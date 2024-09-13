using UnityEngine;

public class UserInput : MonoBehaviour
{
    public const string Horizontal = nameof(Horizontal);
    public const KeyCode Jump = KeyCode.Space;
    public const KeyCode Attack = KeyCode.Q;

    public float Direction { get; private set; }
    public bool IsJump { get; private set; }
    public bool IsAttack { get; private set; }

    private void Update()
    {
        Direction = Input.GetAxis(Horizontal);

        if (Input.GetKeyDown(Jump))
            IsJump = true;
        else
            IsJump = false;

        if (Input.GetKeyDown(Attack))
            IsAttack = true;
        else
            IsAttack = false;
    }
}