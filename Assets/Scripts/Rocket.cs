using System;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    public event Action<Rocket> Died;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent<UserInputSystem>(out UserInputSystem component))
        {
            Died?.Invoke(GetComponent<Rocket>());
        }
    }
}
