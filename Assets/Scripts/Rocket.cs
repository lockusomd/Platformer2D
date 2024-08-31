using System;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    public event Action<Rocket> Died;

    public void RocketDied() {
        Died?.Invoke(GetComponent<Rocket>());
    }
}
