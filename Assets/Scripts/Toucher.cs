using UnityEngine;

public class Toucher : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent<Rocket>(out Rocket component))
        {
            component.RocketDied();
        }
    }
}
