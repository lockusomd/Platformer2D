using UnityEngine;

public class Jumper : MonoBehaviour
{
    [SerializeField] private float _force = 0;
    [SerializeField] private Rigidbody2D _rigidbody;

    public void Jump()
    {
        _rigidbody.velocity = new Vector2(0, 0);
        _rigidbody.AddForce(Vector2.up * _force, ForceMode2D.Impulse);
    }
}