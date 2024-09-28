using UnityEngine;

public class Taker : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out PickupItem component))
        {
            component.ItemDied();
        }
    }
}
