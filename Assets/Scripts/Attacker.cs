using System.Collections;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    [SerializeField] private Damager _damager;

    private IEnumerator Attack()
    {
        _damager.gameObject.SetActive(true);

        yield return new WaitForSeconds(1);

        _damager.gameObject.SetActive(false);
    }

    public void EnableAttack()
    {
        StartCoroutine(Attack());
    }
}
