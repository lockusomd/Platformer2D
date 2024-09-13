using System.Collections;
using UnityEngine;

public class Damager : MonoBehaviour
{
    [SerializeField] private int _power;

    private Coroutine _coroutine;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent<Victim>(out Victim victim))
        {
            _coroutine = StartCoroutine(Attacks(victim));
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent<Victim>(out Victim victim))
        {
            StopCoroutine(_coroutine);
        }
    }

    private void Attack(Victim target)
    {
        target.TakeDamage(_power);
    }

    private IEnumerator Attacks(Victim target)
    {
        bool isWork = true;

        while(isWork)
        {
            Attack(target);

            yield return new WaitForSeconds(3);
        }
    }
}