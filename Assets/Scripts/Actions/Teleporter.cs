using System.Collections;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    const float MinX = -26f;
    const float MaxX = 26f;
    const float MinY = -15f;
    const float MaxY = 15f;

    private void Awake()
    {
        StartCoroutine(ChangePosition());
    }

    private IEnumerator ChangePosition()
    {
        bool isWork = true;

        while (isWork)
        {
            Teleport();

            yield return new WaitForSeconds(5);
        }
    }

    private void Teleport()
    {
        transform.position = new Vector2(Random.Range(MinX, MaxX), Random.Range(MinY, MaxY));
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Ground component))
            Teleport();
    }
}
