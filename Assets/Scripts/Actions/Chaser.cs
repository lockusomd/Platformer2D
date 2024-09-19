using UnityEngine;

public class Chaser : MonoBehaviour
{
    public Transform Target { get; private set; }

    public bool IsChaser { get; private set; }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent<Player>(out Player component))
        {
            Target = component.transform;

            IsChaser = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent<Player>(out Player component))
        {
            IsChaser = false;
        }
    }
}
