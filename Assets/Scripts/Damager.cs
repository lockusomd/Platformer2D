using System.Collections;
using UnityEngine;

public class Damager : MonoBehaviour
{
    [SerializeField] private int _power;

    private Coroutine _coroutine;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Health target))
        {
            _coroutine = StartCoroutine(Attacks(target));
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent<Health>(out _))
        {
            StopCoroutine(_coroutine);
        }
    }

    private void Attack(Health target)
    {
        target.TakeDamage(_power);
    }

    private IEnumerator Attacks(Health target)
    {
        bool isWork = true;

        while(isWork)
        {
            Attack(target);

            yield return new WaitForSeconds(3);
        }
    }
}