using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private Invulner _invulner;
    [SerializeField] private int _minQuantity = 0;
    [SerializeField] private int _maxQuantity = 100;
    [SerializeField] private int _quantity;

    public void TakeDamage(int damage)
    {
        if (damage > 0)
        {
            if (_invulner.IsInvulnerability == false)
            {
                _quantity = Mathf.Clamp(_quantity - damage, _minQuantity, _maxQuantity);

                _invulner.EnableInvulnerability();
            }
        }
    }

    public void Recovery(int healPoints)
    {
        if (healPoints > 0)
            _quantity = Mathf.Clamp(_quantity + healPoints, _minQuantity, _maxQuantity);
    }
}
