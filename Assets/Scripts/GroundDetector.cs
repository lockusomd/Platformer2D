using UnityEngine;

public class GroundDetector : MonoBehaviour
{
    private bool _isGround = false;

    public bool IsGround => _isGround;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Ground component))
            _isGround = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Ground component))
            _isGround = false;
    }
}
