using UnityEngine;

public class Aid : PickupItem
{
    [SerializeField] private int _health;

    public int Health => _health;
}
