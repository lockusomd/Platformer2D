using UnityEngine;

public class Teleporter : MonoBehaviour
{
    const float MinX = -26f;
    const float MaxX = 26f;
    const float MinY = -15f;
    const float MaxY = 15f;

    private void Awake()
    {
        ChangePosition();
    }

    public void ChangePosition()
    {
        transform.position = new Vector2(Random.Range(MinX, MaxX), Random.Range(MinY, MaxY));
    }

    // Не срабатывает триггер на компонент Ground
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Ground component))
            Debug.Log(true);
    }
}
