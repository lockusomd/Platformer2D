using UnityEngine;

public class Victim : MonoBehaviour
{
    [SerializeField] private Invulner _invulner;
    [SerializeField] private int _health;

    public void TakeDamage(int damage)
    {
        if (_invulner.IsInvulnerability == false)
        {
            if (_health > damage)
                _health -= damage;
            else
                _health = 0;

            _invulner.EnableInvulnerability();
        }
    }

    public void Heal(int health)
    {
        _health += health;
    }
}
