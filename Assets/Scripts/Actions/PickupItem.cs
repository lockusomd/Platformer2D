using System;
using UnityEngine;

public class PickupItem : MonoBehaviour
{
    public event Action<PickupItem> Died;

    public void ItemDied()
    {
        Died?.Invoke(this);
    }
}
