using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private Invulner _invulner;
    [SerializeField] private int _minHealth = 0;
    [SerializeField] private int _maxHealth = 100;
    [SerializeField] private int _health;

    public void TakeDamage(int damage)
    {
        if (damage > 0)
        {
            if (_invulner.IsInvulnerability == false)
            {
                _health = Mathf.Clamp(_health - damage, _minHealth, _maxHealth);

                _invulner.EnableInvulnerability();
            }
        }
    }

    public void Heal(int healPoints)
    {
        if (healPoints > 0)
            _health = Mathf.Clamp(_health + healPoints, _minHealth, _maxHealth);

        Debug.Log(healPoints);
    }
}
