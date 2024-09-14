using System.Collections;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    const float MinX = -26f;
    const float MaxX = 26f;
    const float MinY = -15f;
    const float MaxY = 15f;

    private void Start()
    {
        StartCoroutine(ChangePosition());
    }

    private IEnumerator ChangePosition()
    {
        bool isWork = true;

        while(isWork)
        {
            transform.position = new Vector2(Random.Range(MinX, MaxX), Random.Range(MinY, MaxY));

            yield return new WaitForSeconds(5);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Ground component))
            Debug.Log(true);
    }
}
