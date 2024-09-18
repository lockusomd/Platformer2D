using System;
using UnityEngine;

public class Appearer : MonoBehaviour
{
    public event Action<Appearer> Died;

    public void AppearerDied()
    {
        Died?.Invoke(this);
    }
}
